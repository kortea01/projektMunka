namespace RestaurantDesktopApp
{
    partial class Form1
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
            this.listBox_Rendelesek = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderId = new System.Windows.Forms.Label();
            this.textBox_orderID = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.FoodName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FoodName2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.FoodName3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Rendelesek
            // 
            this.listBox_Rendelesek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Rendelesek.FormattingEnabled = true;
            this.listBox_Rendelesek.ItemHeight = 16;
            this.listBox_Rendelesek.Location = new System.Drawing.Point(0, 0);
            this.listBox_Rendelesek.Name = "listBox_Rendelesek";
            this.listBox_Rendelesek.Size = new System.Drawing.Size(135, 450);
            this.listBox_Rendelesek.TabIndex = 0;
            this.listBox_Rendelesek.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.FoodName3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FoodName2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FoodName1);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.textBox_orderID);
            this.groupBox1.Controls.Add(this.OrderId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(135, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kivalasztott_rendeles";
            // 
            // OrderId
            // 
            this.OrderId.AutoSize = true;
            this.OrderId.Location = new System.Drawing.Point(6, 28);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(109, 16);
            this.OrderId.TabIndex = 0;
            this.OrderId.Text = "Rendelés száma";
            // 
            // textBox_orderID
            // 
            this.textBox_orderID.Location = new System.Drawing.Point(131, 28);
            this.textBox_orderID.Name = "textBox_orderID";
            this.textBox_orderID.Size = new System.Drawing.Size(208, 22);
            this.textBox_orderID.TabIndex = 1;
            this.textBox_orderID.TextChanged += new System.EventHandler(this.textBox_orderID_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 120);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(40, 16);
            this.Name.TabIndex = 2;
            this.Name.Text = "Étel 1";
            this.Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // FoodName1
            // 
            this.FoodName1.Location = new System.Drawing.Point(131, 114);
            this.FoodName1.Name = "FoodName1";
            this.FoodName1.Size = new System.Drawing.Size(208, 22);
            this.FoodName1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "db";
            // 
            // numericUpDown_1
            // 
            this.numericUpDown_1.Location = new System.Drawing.Point(454, 114);
            this.numericUpDown_1.Name = "numericUpDown_1";
            this.numericUpDown_1.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown_1.TabIndex = 6;
            this.numericUpDown_1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(454, 142);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "db";
            // 
            // FoodName2
            // 
            this.FoodName2.Location = new System.Drawing.Point(131, 142);
            this.FoodName2.Name = "FoodName2";
            this.FoodName2.Size = new System.Drawing.Size(208, 22);
            this.FoodName2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Étel 2";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(454, 171);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown3.TabIndex = 13;
            // 
            // FoodName3
            // 
            this.FoodName3.Location = new System.Drawing.Point(131, 171);
            this.FoodName3.Name = "FoodName3";
            this.FoodName3.Size = new System.Drawing.Size(208, 22);
            this.FoodName3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Étel 3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "db";
            // 
            // OrderStatus
            // 
            this.OrderStatus.Location = new System.Drawing.Point(131, 62);
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Size = new System.Drawing.Size(208, 22);
            this.OrderStatus.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rendelés státusz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Rendelesek);            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Rendelesek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox textBox_orderID;
        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.TextBox FoodName1;
        private System.Windows.Forms.NumericUpDown numericUpDown_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FoodName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox FoodName3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderStatus;
        private System.Windows.Forms.Label label6;
    }
}

