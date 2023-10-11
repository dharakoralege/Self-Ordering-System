namespace Mcdonald_Sample_project
{
    partial class FormBillToCash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Head To The Cashier Counter\r\nTo Complete Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonHome
            // 
            this.ButtonHome.AnimatedGIF = true;
            this.ButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonHome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonHome.Image = global::Mcdonald_Sample_project.Properties.Resources.home_button_for_interface;
            this.ButtonHome.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButtonHome.ImageRotate = 0F;
            this.ButtonHome.ImageSize = new System.Drawing.Size(32, 32);
            this.ButtonHome.IndicateFocus = true;
            this.ButtonHome.Location = new System.Drawing.Point(12, 615);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonHome.Size = new System.Drawing.Size(34, 30);
            this.ButtonHome.TabIndex = 7;
            this.ButtonHome.UseTransparentBackground = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // FormBillToCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 657);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormBillToCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBillToCash";
            this.Load += new System.EventHandler(this.FormBillToCash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonHome;
    }
}