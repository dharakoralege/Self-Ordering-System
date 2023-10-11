using Mcdonald_Sample_project.ADmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcdonald_Sample_project
{
    public partial class FormAdminProducts : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataSet;
        public FormAdminProducts()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddProducts formAddProducts = new FormAddProducts();
            formAddProducts.ShowDialog();
            this.Hide();
        }

        private void FormAdminProducts_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM products", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "products");
            
            dataGridView1.DataSource = dataSet.Tables["products"];
            conn.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected product ID from the DataGridView
                    string productIdToDelete = dataGridView1.SelectedRows[0].Cells["productID"].Value.ToString();

                    // Delete the selected product from the database
                    conn.Open();
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM products WHERE productID = @productId", conn);
                    deleteCommand.Parameters.AddWithValue("@productId", productIdToDelete);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        // If the deletion was successful, update the DataGridView
                        MessageBox.Show("Product deleted successfully.");
                        dataSet.Clear();
                        adapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables["products"];



                        conn.Open();
                        adapter = new SqlDataAdapter("SELECT * FROM products", conn);
                        dataSet = new DataSet();

                        adapter.Fill(dataSet, "products");
                        dataGridView1.DataSource = dataSet.Tables["products"];
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
    }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormAdminStaff formAdminStaff = new FormAdminStaff();
            formAdminStaff.Show();
            this.Hide();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormAdminProducts formAdminProducts = new FormAdminProducts();
            formAdminProducts.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            form01StartingPage.Show();
            this.Hide();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
 }
