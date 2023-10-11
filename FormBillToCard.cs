using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mcdonald_Sample_project
{
    public partial class FormBillToCard : Form
    {
        public decimal TotalAmount { get; set; }
        public DataTable BillTable { get; set; }

        private PrintDocument printDocument = new PrintDocument();
        public FormBillToCard()
        {
            InitializeComponent();

            
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Form01StartingPage form01StartingPage = new Form01StartingPage();
            form01StartingPage.Show();
            this.Hide();
        }
    }
}
   
