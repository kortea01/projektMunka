namespace RestaurantDesktopApp
{
    partial class IngredientsForm
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
            this.listBox_ingredients = new System.Windows.Forms.ListBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // listBox_ingredients
            // 
            this.listBox_ingredients.DisplayMember = "Name";
            this.listBox_ingredients.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_ingredients.FormattingEnabled = true;
            this.listBox_ingredients.ItemHeight = 16;
            this.listBox_ingredients.Location = new System.Drawing.Point(0, 0);
            this.listBox_ingredients.Name = "listBox_ingredients";
            this.listBox_ingredients.Size = new System.Drawing.Size(278, 450);
            this.listBox_ingredients.TabIndex = 1;
            this.listBox_ingredients.SelectedIndexChanged += new System.EventHandler(this.listBox_ingredients_SelectedIndexChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(454, 27);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(246, 22);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(305, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(104, 16);
            this.name.TabIndex = 3;
            this.name.Text = "Hozzávaló neve";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Allergének";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dairy",
            "gluten",
            "pork",
            "beef",
            "fish",
            "eggs",
            "alcohol"});
            this.comboBox1.Location = new System.Drawing.Point(454, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.listBox_ingredients);
            this.Controls.Add(this.label1);
            this.Name = "FormIngredients";
            this.Load += new System.EventHandler(this.FormIngredients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ingredients;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}