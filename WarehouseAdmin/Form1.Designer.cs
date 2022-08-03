namespace WarehouseAdmin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.categories = new Guna.UI2.WinForms.Guna2Button();
            this.products = new Guna.UI2.WinForms.Guna2Button();
            this.suppliers = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 148);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(551, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Categories, Products and Suppliers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.suppliers);
            this.panel2.Controls.Add(this.products);
            this.panel2.Controls.Add(this.categories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1479, 67);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1479, 416);
            this.panel3.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 215);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1479, 416);
            this.panelContainer.TabIndex = 3;
            // 
            // categories
            // 
            this.categories.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.categories.Checked = true;
            this.categories.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.categories.CheckedState.FillColor = System.Drawing.Color.White;
            this.categories.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.categories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categories.FillColor = System.Drawing.Color.White;
            this.categories.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories.ForeColor = System.Drawing.Color.Black;
            this.categories.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.categories.Location = new System.Drawing.Point(311, 11);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(180, 45);
            this.categories.TabIndex = 0;
            this.categories.Text = "Categories";
            this.categories.Click += new System.EventHandler(this.categories_Click);
            // 
            // products
            // 
            this.products.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.products.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.products.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.products.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.products.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.products.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.products.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.products.FillColor = System.Drawing.Color.White;
            this.products.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.ForeColor = System.Drawing.Color.Black;
            this.products.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.products.Location = new System.Drawing.Point(651, 11);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(180, 45);
            this.products.TabIndex = 1;
            this.products.Text = "Products";
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // suppliers
            // 
            this.suppliers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.suppliers.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.suppliers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.suppliers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.suppliers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.suppliers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.suppliers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.suppliers.FillColor = System.Drawing.Color.White;
            this.suppliers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers.ForeColor = System.Drawing.Color.Black;
            this.suppliers.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.suppliers.Location = new System.Drawing.Point(981, 13);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(180, 45);
            this.suppliers.TabIndex = 2;
            this.suppliers.Text = "Suppliers";
            this.suppliers.Click += new System.EventHandler(this.suppliers_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 631);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button categories;
        private Guna.UI2.WinForms.Guna2Button suppliers;
        private Guna.UI2.WinForms.Guna2Button products;
    }
}

