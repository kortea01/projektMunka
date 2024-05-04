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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_ingredients = new System.Windows.Forms.ListBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Reload = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Allergen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
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
            this.listBox_ingredients.Size = new System.Drawing.Size(278, 645);
            this.listBox_ingredients.TabIndex = 1;
            this.listBox_ingredients.SelectedIndexChanged += new System.EventHandler(this.listBox_ingredients_SelectedIndexChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(323, 40);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(246, 22);
            this.textBox_id.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(323, 78);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(246, 22);
            this.textBox_Name.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 16);
            this.name.TabIndex = 3;
            this.name.Text = "Name of ingredient";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Allergens";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(34, 193);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(116, 52);
            this.button_Create.TabIndex = 7;
            this.button_Create.Text = "New ingredient";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(160, 194);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(116, 52);
            this.button_Reload.TabIndex = 8;
            this.button_Reload.Text = "Reload list";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Location = new System.Drawing.Point(292, 193);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(144, 52);
            this.button_Modify.TabIndex = 9;
            this.button_Modify.Text = "Modify ingredient";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(453, 194);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(116, 52);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Allergen
            // 
            this.textBox_Allergen.Location = new System.Drawing.Point(323, 123);
            this.textBox_Allergen.Name = "textBox_Allergen";
            this.textBox_Allergen.Size = new System.Drawing.Size(246, 22);
            this.textBox_Allergen.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button_Create);
            this.panel1.Controls.Add(this.textBox_Allergen);
            this.panel1.Controls.Add(this.button_Reload);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.button_Modify);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(303, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 267);
            this.panel1.TabIndex = 12;
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1013, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_ingredients);
            this.Name = "IngredientsForm";
            this.Load += new System.EventHandler(this.FormIngredients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ingredients;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_Allergen;
        private System.Windows.Forms.Panel panel1;
    }
}