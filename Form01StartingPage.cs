using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcdonald_Sample_project
{
    public partial class Form01StartingPage : Form
    {
        public Form01StartingPage()
        {
            InitializeComponent();
        }

        private void buttonloginpage_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonstartingpage_Click(object sender, EventArgs e)
        {
            Form01StartingPage formNEW = new Form01StartingPage();
            formNEW.Show();
            this.Hide();
        }

        private void Form001StartingPAge_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonGetstart_Click(object sender, EventArgs e)
        {
            Form02Ordering order = new Form02Ordering();
            order.Show();
            this.Hide();    
        }

        private void Buttonadminloginpage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Only");
            FormAdminLogin adminLogin = new FormAdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
