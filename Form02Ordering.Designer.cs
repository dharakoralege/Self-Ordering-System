namespace Mcdonald_Sample_project
{
    partial class Form02Ordering
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
            this.components = new System.ComponentModel.Container();
            this.TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageItem = new System.Windows.Forms.TabPage();
            this.buttonnext1 = new System.Windows.Forms.Button();
            this.buttonAddtoorder = new System.Windows.Forms.Button();
            this.NumericUpDownQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOrderItem = new System.Windows.Forms.ListBox();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.ColumnHeaderitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListProducts = new System.Windows.Forms.ImageList(this.components);
            this.tabPageDining = new System.Windows.Forms.TabPage();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.checkBoxTakeAway = new System.Windows.Forms.CheckBox();
            this.checkBoxEatin = new System.Windows.Forms.CheckBox();
            this.labelDiningLocation = new System.Windows.Forms.Label();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.checkBoxCards = new System.Windows.Forms.CheckBox();
            this.checkBoxCashCounter = new System.Windows.Forms.CheckBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.ButtonDone = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TabControl1.SuspendLayout();
            this.tabPageItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).BeginInit();
            this.tabPageDining.SuspendLayout();
            this.tabPagePayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.AllowDrop = true;
            this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabControl1.Controls.Add(this.tabPageItem);
            this.TabControl1.Controls.Add(this.tabPageDining);
            this.TabControl1.Controls.Add(this.tabPagePayment);
            this.TabControl1.ItemSize = new System.Drawing.Size(188, 40);
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(572, 623);
            this.TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Transparent;
            this.TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.MistyRose;
            this.TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.MistyRose;
            this.TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.TabControl1.TabButtonSize = new System.Drawing.Size(188, 40);
            this.TabControl1.TabIndex = 3;
            this.TabControl1.TabMenuBackColor = System.Drawing.Color.MistyRose;
            this.TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPageItem
            // 
            this.tabPageItem.BackColor = System.Drawing.Color.Transparent;
            this.tabPageItem.Controls.Add(this.buttonnext1);
            this.tabPageItem.Controls.Add(this.buttonAddtoorder);
            this.tabPageItem.Controls.Add(this.NumericUpDownQuantity);
            this.tabPageItem.Controls.Add(this.label1);
            this.tabPageItem.Controls.Add(this.listBoxOrderItem);
            this.tabPageItem.Controls.Add(this.listViewProducts);
            this.tabPageItem.Location = new System.Drawing.Point(4, 44);
            this.tabPageItem.Name = "tabPageItem";
            this.tabPageItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItem.Size = new System.Drawing.Size(564, 575);
            this.tabPageItem.TabIndex = 1;
            this.tabPageItem.Text = "Choose Items";
            this.tabPageItem.Click += new System.EventHandler(this.tabPageItem_Click);
            // 
            // buttonnext1
            // 
            this.buttonnext1.BackColor = System.Drawing.Color.MistyRose;
            this.buttonnext1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnext1.Location = new System.Drawing.Point(437, 541);
            this.buttonnext1.Name = "buttonnext1";
            this.buttonnext1.Size = new System.Drawing.Size(127, 34);
            this.buttonnext1.TabIndex = 62;
            this.buttonnext1.Text = "Next";
            this.buttonnext1.UseVisualStyleBackColor = false;
            this.buttonnext1.Click += new System.EventHandler(this.buttonnext1_Click);
            // 
            // buttonAddtoorder
            // 
            this.buttonAddtoorder.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAddtoorder.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddtoorder.Location = new System.Drawing.Point(424, 387);
            this.buttonAddtoorder.Name = "buttonAddtoorder";
            this.buttonAddtoorder.Size = new System.Drawing.Size(128, 30);
            this.buttonAddtoorder.TabIndex = 61;
            this.buttonAddtoorder.Text = "Add To Order";
            this.buttonAddtoorder.UseVisualStyleBackColor = false;
            this.buttonAddtoorder.Click += new System.EventHandler(this.buttonAddtoorder_Click);
            // 
            // NumericUpDownQuantity
            // 
            this.NumericUpDownQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NumericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericUpDownQuantity.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownQuantity.Location = new System.Drawing.Point(297, 387);
            this.NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            this.NumericUpDownQuantity.Size = new System.Drawing.Size(121, 30);
            this.NumericUpDownQuantity.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // listBoxOrderItem
            // 
            this.listBoxOrderItem.BackColor = System.Drawing.Color.White;
            this.listBoxOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOrderItem.FormattingEnabled = true;
            this.listBoxOrderItem.ItemHeight = 20;
            this.listBoxOrderItem.Location = new System.Drawing.Point(0, 383);
            this.listBoxOrderItem.Name = "listBoxOrderItem";
            this.listBoxOrderItem.Size = new System.Drawing.Size(291, 200);
            this.listBoxOrderItem.TabIndex = 1;
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.Color.White;
            this.listViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderitem,
            this.ColumnHeaderprice});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.LargeImageList = this.imageListProducts;
            this.listViewProducts.Location = new System.Drawing.Point(-4, 0);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(568, 381);
            this.listViewProducts.SmallImageList = this.imageListProducts;
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // ColumnHeaderitem
            // 
            this.ColumnHeaderitem.Text = "Item";
            this.ColumnHeaderitem.Width = 452;
            // 
            // ColumnHeaderprice
            // 
            this.ColumnHeaderprice.Text = "Price";
            this.ColumnHeaderprice.Width = 100;
            // 
            // imageListProducts
            // 
            this.imageListProducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListProducts.ImageSize = new System.Drawing.Size(128, 128);
            this.imageListProducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPageDining
            // 
            this.tabPageDining.BackColor = System.Drawing.Color.MistyRose;
            this.tabPageDining.Controls.Add(this.buttonNext2);
            this.tabPageDining.Controls.Add(this.checkBoxTakeAway);
            this.tabPageDining.Controls.Add(this.checkBoxEatin);
            this.tabPageDining.Controls.Add(this.labelDiningLocation);
            this.tabPageDining.Location = new System.Drawing.Point(4, 44);
            this.tabPageDining.Name = "tabPageDining";
            this.tabPageDining.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDining.Size = new System.Drawing.Size(564, 575);
            this.tabPageDining.TabIndex = 2;
            this.tabPageDining.Text = "Dining Type";
            // 
            // buttonNext2
            // 
            this.buttonNext2.BackColor = System.Drawing.Color.MistyRose;
            this.buttonNext2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext2.Location = new System.Drawing.Point(437, 541);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(127, 34);
            this.buttonNext2.TabIndex = 59;
            this.buttonNext2.Text = "Next";
            this.buttonNext2.UseVisualStyleBackColor = false;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // checkBoxTakeAway
            // 
            this.checkBoxTakeAway.AutoSize = true;
            this.checkBoxTakeAway.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTakeAway.Location = new System.Drawing.Point(256, 354);
            this.checkBoxTakeAway.Name = "checkBoxTakeAway";
            this.checkBoxTakeAway.Size = new System.Drawing.Size(155, 32);
            this.checkBoxTakeAway.TabIndex = 56;
            this.checkBoxTakeAway.Text = "Take Away";
            this.checkBoxTakeAway.UseVisualStyleBackColor = true;
            // 
            // checkBoxEatin
            // 
            this.checkBoxEatin.AutoSize = true;
            this.checkBoxEatin.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEatin.Location = new System.Drawing.Point(119, 354);
            this.checkBoxEatin.Name = "checkBoxEatin";
            this.checkBoxEatin.Size = new System.Drawing.Size(100, 32);
            this.checkBoxEatin.TabIndex = 55;
            this.checkBoxEatin.Text = "Eat in";
            this.checkBoxEatin.UseVisualStyleBackColor = true;
            // 
            // labelDiningLocation
            // 
            this.labelDiningLocation.AutoSize = true;
            this.labelDiningLocation.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiningLocation.Location = new System.Drawing.Point(113, 135);
            this.labelDiningLocation.Name = "labelDiningLocation";
            this.labelDiningLocation.Size = new System.Drawing.Size(312, 44);
            this.labelDiningLocation.TabIndex = 0;
            this.labelDiningLocation.Text = "Dining Location";
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.BackColor = System.Drawing.Color.MistyRose;
            this.tabPagePayment.Controls.Add(this.checkBoxCards);
            this.tabPagePayment.Controls.Add(this.checkBoxCashCounter);
            this.tabPagePayment.Controls.Add(this.labelPayment);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 44);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayment.Size = new System.Drawing.Size(564, 575);
            this.tabPagePayment.TabIndex = 3;
            this.tabPagePayment.Text = "Payment Type";
            // 
            // checkBoxCards
            // 
            this.checkBoxCards.AutoSize = true;
            this.checkBoxCards.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCards.Location = new System.Drawing.Point(333, 375);
            this.checkBoxCards.Name = "checkBoxCards";
            this.checkBoxCards.Size = new System.Drawing.Size(97, 32);
            this.checkBoxCards.TabIndex = 58;
            this.checkBoxCards.Text = "Cards";
            this.checkBoxCards.UseVisualStyleBackColor = true;
            // 
            // checkBoxCashCounter
            // 
            this.checkBoxCashCounter.AutoSize = true;
            this.checkBoxCashCounter.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCashCounter.Location = new System.Drawing.Point(107, 375);
            this.checkBoxCashCounter.Name = "checkBoxCashCounter";
            this.checkBoxCashCounter.Size = new System.Drawing.Size(185, 32);
            this.checkBoxCashCounter.TabIndex = 57;
            this.checkBoxCashCounter.Text = "Cash Counter";
            this.checkBoxCashCounter.UseVisualStyleBackColor = true;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(26, 121);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(527, 41);
            this.labelPayment.TabIndex = 1;
            this.labelPayment.Text = "How Would You Like To Pay?";
            // 
            // ButtonDone
            // 
            this.ButtonDone.Animated = true;
            this.ButtonDone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDone.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDone.FillColor = System.Drawing.Color.MistyRose;
            this.ButtonDone.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonDone.ForeColor = System.Drawing.Color.Black;
            this.ButtonDone.Location = new System.Drawing.Point(434, 625);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.Size = new System.Drawing.Size(134, 30);
            this.ButtonDone.TabIndex = 4;
            this.ButtonDone.Text = "Done";
            this.ButtonDone.Click += new System.EventHandler(this.ButtonDone_Click);
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
            this.ButtonHome.Location = new System.Drawing.Point(4, 625);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonHome.Size = new System.Drawing.Size(34, 30);
            this.ButtonHome.TabIndex = 5;
            this.ButtonHome.UseTransparentBackground = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // Form02Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(569, 657);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonDone);
            this.Controls.Add(this.TabControl1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form02Ordering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form002Ordering";
            this.Load += new System.EventHandler(this.Form002Ordering_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPageItem.ResumeLayout(false);
            this.tabPageItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).EndInit();
            this.tabPageDining.ResumeLayout(false);
            this.tabPageDining.PerformLayout();
            this.tabPagePayment.ResumeLayout(false);
            this.tabPagePayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPageItem;
        private System.Windows.Forms.Button buttonnext1;
        private System.Windows.Forms.Button buttonAddtoorder;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUpDownQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrderItem;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.TabPage tabPageDining;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.CheckBox checkBoxTakeAway;
        private System.Windows.Forms.CheckBox checkBoxEatin;
        private System.Windows.Forms.Label labelDiningLocation;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.CheckBox checkBoxCards;
        private System.Windows.Forms.CheckBox checkBoxCashCounter;
        private System.Windows.Forms.Label labelPayment;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonDone;
        private System.Windows.Forms.ImageList imageListProducts;
        private System.Windows.Forms.ColumnHeader ColumnHeaderitem;
        private System.Windows.Forms.ColumnHeader ColumnHeaderprice;
        private Guna.UI2.WinForms.Guna2ImageButton ButtonHome;
    }
}