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
    public partial class FormBillitems : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataset;
        public FormBillitems()
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

        private void FormBillitems_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Bill_OrderdProducts", conn);
            dataset = new DataSet();
            adapter.Fill(dataset, "Bill_OrderdProducts");

            dataGridView1.DataSource = dataset.Tables["Bill_OrderdProducts"];
            conn.Close();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            form01StartingPage.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
