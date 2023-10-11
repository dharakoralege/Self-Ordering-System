using Mcdonald_Sample_project.ADmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcdonald_Sample_project
{
    public partial class FormAdminStaff : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataSet;
        public FormAdminStaff()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            FormAdminStaff formAdminStaff = new FormAdminStaff();
            formAdminStaff.Show();
            this.Hide();
        }

        private void FormAdminStaff_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Employee", conn);
            dataSet = new DataSet();

            adapter.Fill(dataSet, "Employee");
            dataGridView1.DataSource = dataSet.Tables["Employee"];


            conn.Close();
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

        private void button1add_Click(object sender, EventArgs e)
        {
            FormAddStaff formAddStaff = new FormAddStaff(); 
            formAddStaff.ShowDialog();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected product ID from the DataGridView
                    string employeetodelete = dataGridView1.SelectedRows[0].Cells["NIC"].Value.ToString();

                    // Delete the selected product from the database
                    conn.Open();
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Employee WHERE NIC = @nic", conn);
                    deleteCommand.Parameters.AddWithValue("@nic", employeetodelete);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        // If the deletion was successful, update the DataGridView
                        MessageBox.Show("Employee deleted successfully.");
                        dataSet.Clear();
                        adapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables["Employee"];

                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the Employee Data.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Employee to delete.");
                }
            }
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Employee", conn);
            dataSet = new DataSet();

            adapter.Fill(dataSet, "Employee");
            dataGridView1.DataSource = dataSet.Tables["Employee"];
            conn.Close();
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

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            form01StartingPage.Show();
            this.Hide();
        }
        private void buttonedit_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
