using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Mcdonald_Sample_project
{
    public partial class Form02Ordering : Form
    {
        decimal totalAmount = 0;
        string orderType;
        string paymentType;

        SqlConnection conn;
        DataTable billTable;

        public Form02Ordering()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");
            billTable = new DataTable();
        }

        private void Form002Ordering_Load(object sender, EventArgs e)
        {
            billTable.Columns.Add("ProductID", typeof(string));
            billTable.Columns.Add("ProductName", typeof(string));
            billTable.Columns.Add("Price", typeof(decimal)); 
            billTable.Columns.Add("StockQuantity", typeof(int));



            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM products", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                byte[] productimage = (byte[])reader["ProductImage"];
                string productname = reader["ProductName"].ToString();
                decimal productPrice = reader.GetDecimal(reader.GetOrdinal("Price")); 
                int StockQuantity = Convert.ToInt32(reader["StockQuantity"]);
                

                using (MemoryStream ms = new MemoryStream(productimage))
                {
                    Image image = Image.FromStream(ms);
                    imageListProducts.Images.Add(productname, image);
                }


                ListViewItem item = new ListViewItem(productname);
                item.ImageKey = productname;
                item.SubItems.Add("LKR " + productPrice.ToString("#,##0")); 

                listViewProducts.Items.Add(item);

            }
            conn.Close();
        }

        private string GetProductID(string productName)
        {
            string productID = null; // Default value is null

            conn.Open();

            SqlCommand getIDCommand = new SqlCommand("SELECT ProductID FROM products WHERE ProductName = @ProductName", conn);
            getIDCommand.Parameters.AddWithValue("@ProductName", productName);

            object result = getIDCommand.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                productID = result.ToString(); // Convert to string
            }

            conn.Close();

            return productID;
        }

        private void buttonAddtoorder_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listViewProducts.SelectedItems)
            {
                DataRow newRow = billTable.NewRow();
                newRow["ProductID"] = GetProductID(selectedItem.Text);
                newRow["ProductName"] = selectedItem.Text;

                string priceString = selectedItem.SubItems[1].Text.Replace("LKR", "").Replace(",", "");

                if (decimal.TryParse(priceString, out decimal price))
                {
                    newRow["Price"] = price.ToString(); 
                }
                else
                {
                    newRow["Price"] = "0.00"; 
                }

                // Get the quantity from the NumericUpDown control
                int quantity = (int)NumericUpDownQuantity.Value;
                newRow["StockQuantity"] = quantity;

                billTable.Rows.Add(newRow);


                UpdateProductStockQuantity(selectedItem.Text, quantity);

                UpdateBillListBox();
            }
            CalculateTotalAmount();
        }

        private void UpdateProductStockQuantity(string productName, int quantity)
        {
            conn.Open();

            // Retrieve the current StockQuantity from the Product table
            SqlCommand getQuantityCommand = new SqlCommand("SELECT StockQuantity FROM products WHERE ProductName = @ProductName", conn);
            getQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
            int currentQuantity = (int)getQuantityCommand.ExecuteScalar();

            // Calculate the new StockQuantity after subtracting the quantity
            int newQuantity = currentQuantity - quantity;

            // Update the StockQuantity in the Product table
            SqlCommand updateQuantityCommand = new SqlCommand("UPDATE products SET StockQuantity = @NewQuantity WHERE ProductName = @ProductName", conn);
            updateQuantityCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
            updateQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
            updateQuantityCommand.ExecuteNonQuery();

            conn.Close();
        }

        private void UpdateBillListBox()
        {
            listBoxOrderItem.Items.Clear();
            foreach (DataRow row in billTable.Rows)

            {
                _ = listBoxOrderItem.Items.Add(row["ProductName"] + " - LKR" + row["Price"] + " - " + row["StockQuantity"]);



            }
        }

        private void CalculateTotalAmount()
        {
            totalAmount = 0;
            foreach (DataRow row in billTable.Rows)
            {
                decimal price = (decimal)row["Price"];
                int quantity = (int)row["StockQuantity"];
                totalAmount += price * quantity;
            }

            // Display the total amount in a label
            label1.Text = "Total Amount: \n LKR " + totalAmount.ToString("#,##0.00"); 
            // Format as currency with two decimal places
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            if (listBoxOrderItem.Items.Count > 0)
            {
                orderType = GetOrderType(); // Call the function to get the order type
                paymentType = GetPaymentType(); // Call the function to get the payment type

                // Store the bill details in the database
                try
                {
                    conn.Open();

                    // Insert bill details into the bill table
                    SqlCommand insertBillCommand = new SqlCommand("INSERT INTO Bill (TotalAmount,orderType, PaymentStatus) VALUES (@TotalAmount,@orderType,@PaymentStatus); SELECT SCOPE_IDENTITY();", conn);
                    insertBillCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    insertBillCommand.Parameters.AddWithValue("@orderType", orderType);
                    insertBillCommand.Parameters.AddWithValue("@PaymentStatus", paymentType);
                    int billID = Convert.ToInt32(insertBillCommand.ExecuteScalar());


                    


                    // Insert ordered items into the ordered items table
                    foreach (DataRow row in billTable.Rows)
                    {

                        SqlCommand insertOrderCommand = new SqlCommand("INSERT INTO Bill_OrderdProducts " +
                            "(BillID, ProductID, Quantity) " +
                            "VALUES (@BillID, @ProductID, @Quantity)",
                            conn);
                        insertOrderCommand.Parameters.AddWithValue("@BillID", billID);
                        insertOrderCommand.Parameters.AddWithValue("@Quantity", row["StockQuantity"]);
                        insertOrderCommand.Parameters.AddWithValue("@ProductID", row["ProductID"]);




                        insertOrderCommand.ExecuteNonQuery();
                    }



                    string paymentStatus = GetPaymentType();

                    // Open different forms based on the payment status
                    if (paymentStatus == "Card")
                    {
                      
                        FormBillToCard cardPaymentForm = new FormBillToCard();
                        cardPaymentForm.TotalAmount = totalAmount;
                        cardPaymentForm.BillTable = billTable;
                        this.Hide();
                        cardPaymentForm.Show();
                       
                    }
                    else if (paymentStatus == "Cash")
                    {
                        FormBillToCash cashPaymentForm = new FormBillToCash();
                        cashPaymentForm.TotalAmount = totalAmount;
                        cashPaymentForm.BillTable = billTable;
                        this.Hide();
                        cashPaymentForm.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Try again" + ex.Message);
                }
                finally
                {
                    checkBoxEatin.Checked = false;
                    checkBoxTakeAway.Checked = false;
                    checkBoxCashCounter.Checked = false;
                    checkBoxCards.Checked = false;
                    listBoxOrderItem.Items.Clear();
                    NumericUpDownQuantity.Value = 0;

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("No items in the bill.");
            }
        }


        private string GetOrderType()
        {
            orderType = "";
            if (checkBoxEatin.Checked)
            {
                orderType = "Eat in";
            }
            if (checkBoxTakeAway.Checked)
            {
                orderType = "Take Away";
            }
            return orderType;
        }

        private string GetPaymentType()
        {
            paymentType = "";
            if (checkBoxCashCounter.Checked)
            {
                paymentType = "Cash";
            }
            if (checkBoxCards.Checked)
            {
                paymentType = "Card";
            }
            return paymentType;
        }

        private void buttonnext1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPageDining;
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPagePayment;

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            form01StartingPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBillPreview_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPageItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
