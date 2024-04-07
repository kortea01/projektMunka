namespace RestaurantDesktopApp
{
    partial class Form2
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
            this.label7 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(651, 70);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(265, 22);
            this.OrderID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategória";
            // 
            // listBox_RestaurantMenu
            // 
            this.listBox_RestaurantMenu.DisplayMember = "Name";
            this.listBox_RestaurantMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_RestaurantMenu.FormattingEnabled = true;
            this.listBox_RestaurantMenu.ItemHeight = 16;
            this.listBox_RestaurantMenu.Location = new System.Drawing.Point(0, 0);
            this.listBox_RestaurantMenu.Name = "listBox_RestaurantMenu";
            this.listBox_RestaurantMenu.Size = new System.Drawing.Size(450, 571);
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
            this.comboBox_Category.Location = new System.Drawing.Point(651, 107);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(265, 24);
            this.comboBox_Category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ár";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(653, 221);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(145, 22);
            this.numericUpDownPrice.TabIndex = 7;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.ingerdientsCombo.Location = new System.Drawing.Point(650, 258);
            this.ingerdientsCombo.Name = "ingerdientsCombo";
            this.ingerdientsCombo.Size = new System.Drawing.Size(265, 24);
            this.ingerdientsCombo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alapanyag";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(653, 145);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(265, 22);
            this.textBox_Name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Étel neve";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(653, 183);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(265, 22);
            this.textBox_Description.TabIndex = 13;
            this.textBox_Description.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Részletesen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Új";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(492, 344);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(94, 38);
            this.button_Create.TabIndex = 15;
            this.button_Create.Text = "New";
            this.button_Create.UseVisualStyleBackColor = true;
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(605, 344);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(100, 38);
            this.button_Read.TabIndex = 16;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = true;
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(724, 344);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(100, 38);
            this.button_Modify.TabIndex = 17;
            this.button_Modify.Text = "Modifying";
            this.button_Modify.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingerdientsCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.listBox_RestaurantMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button1;
    }
}