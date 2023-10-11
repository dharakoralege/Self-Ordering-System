namespace Mcdonald_Sample_project
{
    partial class FormAdminStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonlogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonBillitems = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1add = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonlogout);
            this.panel1.Controls.Add(this.buttonBillitems);
            this.panel1.Controls.Add(this.buttonBill);
            this.panel1.Controls.Add(this.buttonStaff);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 132);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonlogout
            // 
            this.buttonlogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonlogout.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.buttonlogout.Image = global::Mcdonald_Sample_project.Properties.Resources.logout;
            this.buttonlogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonlogout.ImageRotate = 0F;
            this.buttonlogout.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonlogout.IndicateFocus = true;
            this.buttonlogout.Location = new System.Drawing.Point(849, 3);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.buttonlogout.Size = new System.Drawing.Size(43, 40);
            this.buttonlogout.TabIndex = 8;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttonBillitems
            // 
            this.buttonBillitems.BackColor = System.Drawing.Color.White;
            this.buttonBillitems.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillitems.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBillitems.Location = new System.Drawing.Point(696, 89);
            this.buttonBillitems.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBillitems.Name = "buttonBillitems";
            this.buttonBillitems.Size = new System.Drawing.Size(185, 38);
            this.buttonBillitems.TabIndex = 7;
            this.buttonBillitems.Text = "Bill Items";
            this.buttonBillitems.UseVisualStyleBackColor = false;
            this.buttonBillitems.Click += new System.EventHandler(this.buttonBillitems_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.BackColor = System.Drawing.Color.White;
            this.buttonBill.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBill.Location = new System.Drawing.Point(463, 89);
            this.buttonBill.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(185, 38);
            this.buttonBill.TabIndex = 6;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = false;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.White;
            this.buttonStaff.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStaff.Location = new System.Drawing.Point(231, 89);
            this.buttonStaff.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(185, 38);
            this.buttonStaff.TabIndex = 3;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(5, 48);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(893, 14);
            this.guna2Separator1.TabIndex = 1;
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.White;
            this.buttonProducts.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProducts.Location = new System.Drawing.Point(17, 89);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(5);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(185, 38);
            this.buttonProducts.TabIndex = 0;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Management System";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(190, 147);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(69, 26);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1add
            // 
            this.button1add.BackColor = System.Drawing.Color.Transparent;
            this.button1add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1add.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1add.ForeColor = System.Drawing.Color.Black;
            this.button1add.Location = new System.Drawing.Point(115, 147);
            this.button1add.Name = "button1add";
            this.button1add.Size = new System.Drawing.Size(69, 26);
            this.button1add.TabIndex = 8;
            this.button1add.Text = "Add";
            this.button1add.UseVisualStyleBackColor = false;
            this.button1add.Click += new System.EventHandler(this.button1add_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.BackgroundImage")));
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(265, 147);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(27, 25);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 417);
            this.dataGridView1.TabIndex = 13;
            // 
            // FormAdminStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(921, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.button1add);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminStaff";
            this.Load += new System.EventHandler(this.FormAdminStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1add;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Button buttonBillitems;
        private Guna.UI2.WinForms.Guna2ImageButton buttonlogout;
    }
}