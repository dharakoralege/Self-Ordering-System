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
    public partial class FormAddStaff : Form
    {   SqlConnection conn;
        public FormAddStaff()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdminStaff formAdminStaff = new FormAdminStaff();
            formAdminStaff.Show();
            this.Hide();
        }

        private void FormAddStaff_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNIC.Text) ||
            string.IsNullOrWhiteSpace(textBoxEmployeeName.Text) ||
            string.IsNullOrWhiteSpace(textBoxEaddress.Text) ||
            string.IsNullOrWhiteSpace(textBoxEcontact.Text) ||
            string.IsNullOrWhiteSpace(textBoxusername.Text) ||
            string.IsNullOrWhiteSpace(textBoxpassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Stop further processing
            }
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Employee(NIC,EName,EAddress,ENumber,Eusername,Epassword) " +
                "VALUES(@nic, @name, @address, @number, @username, @password)", conn);
            sqlCommand.Parameters.AddWithValue("@nic", textBoxNIC.Text);
            sqlCommand.Parameters.AddWithValue("@name", textBoxEmployeeName.Text);
            sqlCommand.Parameters.AddWithValue("@address", textBoxEaddress.Text);
            sqlCommand.Parameters.AddWithValue("@number", Convert.ToInt32 (textBoxEcontact.Text));
            sqlCommand.Parameters.AddWithValue("@username", textBoxusername.Text);
            sqlCommand.Parameters.AddWithValue("@password", textBoxpassword.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Saved");

            textBoxNIC.Clear();
            textBoxEmployeeName.Clear();
            textBoxEaddress.Clear();
            textBoxEcontact.Clear();
            textBoxusername.Clear();
            textBoxpassword.Clear();

            conn.Close();
        }
    }
}
