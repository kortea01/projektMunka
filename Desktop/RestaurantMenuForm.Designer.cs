namespace RestaurantDesktopApp
{
    partial class RestaurantMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_RestaurantMenu = new System.Windows.Forms.ListBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.ingerdientsCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(249, 50);
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Size = new System.Drawing.Size(265, 22);
            this.OrderID.TabIndex = 1;
            this.OrderID.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // listBox_RestaurantMenu
            // 
            this.listBox_RestaurantMenu.DisplayMember = "Name";
            this.listBox_RestaurantMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_RestaurantMenu.FormattingEnabled = true;
            this.listBox_RestaurantMenu.ItemHeight = 16;
            this.listBox_RestaurantMenu.Location = new System.Drawing.Point(0, 0);
            this.listBox_RestaurantMenu.Name = "listBox_RestaurantMenu";
            this.listBox_RestaurantMenu.Size = new System.Drawing.Size(316, 716);
            this.listBox_RestaurantMenu.TabIndex = 4;
            this.listBox_RestaurantMenu.SelectedIndexChanged += new System.EventHandler(this.listBox_RestaurantMenu_SelectedIndexChanged);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "leves",
            "pizza",
            "saláta",
            "tészta",
            "desszert",
            "italok"});
            this.comboBox_Category.Location = new System.Drawing.Point(249, 87);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(265, 24);
            this.comboBox_Category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(412, 201);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownPrice.TabIndex = 7;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // ingerdientsCombo
            // 
            this.ingerdientsCombo.FormattingEnabled = true;
            this.ingerdientsCombo.Items.AddRange(new object[] {
            "paradicsomszósz",
            "pizza liszt",
            "canneloni",
            "ricotta",
            "mozzarella",
            "cékla",
            "olívaolaj",
            "só",
            "bors",
            "oregánó",
            "bazsalikom",
            "babapiskóta",
            "diavola",
            "zellerszár",
            "cannelini",
            "tejszín",
            "mascarpone",
            "tojás"});
            this.ingerdientsCombo.Location = new System.Drawing.Point(328, 316);
            this.ingerdientsCombo.Name = "ingerdientsCombo";
            this.ingerdientsCombo.Size = new System.Drawing.Size(186, 24);
            this.ingerdientsCombo.TabIndex = 9;
            this.ingerdientsCombo.SelectedIndexChanged += new System.EventHandler(this.ingerdientsCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingredients";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(249, 125);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(265, 22);
            this.textBox_Name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name of the food";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(249, 163);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(265, 22);
            this.textBox_Description.TabIndex = 13;
            this.textBox_Description.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "More details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(50, 383);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(94, 38);
            this.button_Create.TabIndex = 15;
            this.button_Create.Text = "New food";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(163, 383);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(100, 38);
            this.button_Read.TabIndex = 16;
            this.button_Read.Text = "Reload list";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(282, 383);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(100, 38);
            this.button_Modify.TabIndex = 17;
            this.button_Modify.Text = "Modify food";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(414, 383);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(100, 38);
            this.button_Delete.TabIndex = 18;
            this.button_Delete.Text = "Delete food";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(328, 238);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(186, 72);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.OrderID);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_Modify);
            this.panel1.Controls.Add(this.comboBox_Category);
            this.panel1.Controls.Add(this.button_Read);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_Create);
            this.panel1.Controls.Add(this.numericUpDownPrice);
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ingerdientsCombo);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(338, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 479);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RestaurantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_RestaurantMenu);
            this.Name = "RestaurantMenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.RestaurantMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_RestaurantMenu;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox ingerdientsCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
    }
}