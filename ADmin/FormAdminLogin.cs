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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mcdonald_Sample_project
{
    public partial class FormAdminLogin : Form
    {
        SqlConnection conn;
        SqlDataReader reader;
        public FormAdminLogin()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.;Initial Catalog=projectdb;Integrated Security=True");

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username = textBoxusername.Text;
            SqlCommand sqlCommand = new SqlCommand("SELECT Eusername,Epassword FROM Employee WHERE Eusername = @username AND Epassword=@password", conn);
            sqlCommand.Parameters.AddWithValue("@username", textBoxusername.Text);
            sqlCommand.Parameters.AddWithValue("@password", textBoxpassword.Text);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {

                FormAdminProducts form = new FormAdminProducts();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login faild!");
                textBoxusername.Clear();
                textBoxpassword.Clear();
            }
            conn.Close();
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
