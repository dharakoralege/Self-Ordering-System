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
    public partial class FormBillToCash : Form
    {
        public decimal TotalAmount { get; set; }
        public DataTable BillTable { get; set; }


        public FormBillToCash()
        {
            InitializeComponent();
        }

        private void FormBillToCash_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            int startX = 50; // Starting X coordinate for drawing
            int startY = 50; // Starting Y coordinate for drawing
            int lineHeight = 20; // Height of each line

            // Draw a title
            string title = "Your Order";
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            graphics.DrawString(title, titleFont, Brushes.Black, startX, startY);
            startY += lineHeight * 2; // Move down two lines

         
            // Draw bill details
            string totalAmountText = "Total Amount: " + TotalAmount.ToString() + " LKR "; // Format as currency
            graphics.DrawString(totalAmountText, new Font("Arial", 12), Brushes.Black, startX, startY);
            startY += lineHeight;

            // Draw a line separator
            graphics.DrawLine(new Pen(Brushes.Black), startX, startY, this.Width - startX, startY);
            startY += lineHeight;

            // Draw the list of bill items from the DataTable
            foreach (DataRow row in BillTable.Rows)
            {
                string itemName = row["ProductName"].ToString();
                string itemPrice = "Price: " + row["Price"].ToString();
                string itemQuantity = "Quantity: " + row["StockQuantity"].ToString();

                string itemText = itemName + " (" + itemPrice + ", " + itemQuantity + ")";
                graphics.DrawString(itemText, new Font("Arial", 10), Brushes.Black, startX, startY);

                startY += lineHeight;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            this.Hide();
            form01StartingPage.Show();
        }
    }
}
