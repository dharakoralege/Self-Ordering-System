using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Mcdonald_Sample_project.ADmin
{
    public partial class FormBill : Form
    {
        SqlConnection conn;
        DataSet dataset;
        SqlDataAdapter adapter;
        public FormBill()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormAdminProducts formAdminProducts = new FormAdminProducts();
            formAdminProducts.Show();
            this.Hide();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormAdminStaff formAdminStaff = new FormAdminStaff();
            formAdminStaff.Show();
            this.Hide();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            FormBill formBill = new FormBill();
            formBill.Show();
            this.Hide();
        }

        private void buttonBillitems_Click(object sender, EventArgs e)
        {
            FormBillitems formBillitems = new FormBillitems();
            formBillitems.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Bill", conn);
            dataset = new DataSet();
            adapter.Fill(dataset, "Bill");

            dataGridView1.DataSource = dataset.Tables["Bill"];
            conn.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    // Get the selected product ID from the DataGridView
                    string BillIDdelete = dataGridView1.SelectedRows[0].Cells["BillID"].Value.ToString();

                    // Delete related records from the Bill_OrderdProducts table first
                            conn.Open();
                     SqlCommand deleteRelatedItemsCommand = new SqlCommand("DELETE FROM Bill_OrderdProducts WHERE BillID = @BillID", conn);
                    deleteRelatedItemsCommand.Parameters.AddWithValue("@BillID", BillIDdelete);
                    int relatedRowsAffected = deleteRelatedItemsCommand.ExecuteNonQuery();


                    // Delete the selected product from the database
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Bill WHERE BillID = @BillID", conn);
                    deleteCommand.Parameters.AddWithValue("@BillID",BillIDdelete);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        // If the deletion was successful, update the DataGridView
                        MessageBox.Show("Bill Item deleted successfully."); 
                        dataset.Clear();
                        adapter.Fill(dataset);
                        dataGridView1.DataSource = dataset.Tables["Bill"];

                        conn.Open();
                        adapter = new SqlDataAdapter("SELECT * FROM Bill", conn);
                        dataset = new DataSet();

                        adapter.Fill(dataset, "Bill");
                        dataGridView1.DataSource = dataset.Tables["Bill"];
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the Bill item.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Bill item to delete.");
                }
            }
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            form01StartingPage.Show();
            this.Hide();
        }
    }
}
