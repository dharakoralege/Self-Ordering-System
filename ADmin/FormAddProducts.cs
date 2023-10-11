using Mcdonald_Sample_project.ADmin;
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

namespace Mcdonald_Sample_project
{
    public partial class FormAddProducts : Form
    {
        private byte[] imageData;
        SqlConnection conn;


        public FormAddProducts()
        {
            InitializeComponent();
           

            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");
        }

        private void FormAddProducts_Load(object sender, EventArgs e)
        {            
            
            this.employeeTableAdapter.Fill(this.projectdbDataSet2.Employee);

           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdminProducts formAdminProducts = new FormAdminProducts();
            formAdminProducts.Show();
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (imageData == null || imageData.Length == 0)
            {
                MessageBox.Show("Please upload an image for the product.");
                return; // Stop further processing
            }

            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO products(productID,ProductName,Price,StockQuantity,ProductImage)" +
                " VALUES(@PRODUCTid, @PRODUCTname, @PRICE, @QUANTITY,@iMAGE) ", conn);
            sqlCommand.Parameters.AddWithValue("@PRODUCTid", textBoxproductID.Text);
            sqlCommand.Parameters.AddWithValue("@PRODUCTname", textBoxProductName.Text);
            sqlCommand.Parameters.AddWithValue("@PRICE", Convert.ToDouble(textBoxPrice.Text));
            sqlCommand.Parameters.AddWithValue("@QUANTITY" ,Convert.ToInt32 (textBoxStockQuantity.Text));

            sqlCommand.Parameters.AddWithValue("@iMAGE", imageData);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Saved");         

            textBoxProductName.Clear();
            textBoxproductID.Clear();
            textBoxPrice.Clear();
            textBoxStockQuantity.Clear();
           

            conn.Close();

        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    // Convert the selected image to a byte array
                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                }

            }
            
    }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddNewCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
