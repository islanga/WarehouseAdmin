namespace WarehouseAdmin.AdminControls
{
    partial class Admin_Products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.resultGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproductid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtproductname = new Guna.UI2.WinForms.Guna2TextBox();
            this.description = new System.Windows.Forms.Label();
            this.categoryname = new System.Windows.Forms.Label();
            this.txtsupplierid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtcategoryid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqtyperunit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiscontinued = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtreorderlevel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtunitsonorder = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtunitsinstock = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtunitprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.btnshowall = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.Update = new Guna.UI2.WinForms.Guna2Button();
            this.btninsert = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // resultGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.resultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultGrid.BackgroundColor = System.Drawing.Color.White;
            this.resultGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultGrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultGrid.EnableHeadersVisualStyles = false;
            this.resultGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultGrid.Location = new System.Drawing.Point(565, 29);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.RowHeadersVisible = false;
            this.resultGrid.RowHeadersWidth = 51;
            this.resultGrid.RowTemplate.Height = 24;
            this.resultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultGrid.Size = new System.Drawing.Size(812, 316);
            this.resultGrid.TabIndex = 10;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.resultGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.resultGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.resultGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.resultGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.resultGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.resultGrid.ThemeStyle.ReadOnly = false;
            this.resultGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.resultGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.resultGrid.ThemeStyle.RowsStyle.Height = 24;
            this.resultGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.resultGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Id";
            // 
            // txtproductid
            // 
            this.txtproductid.BackColor = System.Drawing.Color.Transparent;
            this.txtproductid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtproductid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtproductid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproductid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproductid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtproductid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtproductid.ItemHeight = 30;
            this.txtproductid.Location = new System.Drawing.Point(246, 18);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(273, 36);
            this.txtproductid.TabIndex = 13;
            // 
            // txtproductname
            // 
            this.txtproductname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtproductname.DefaultText = "";
            this.txtproductname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtproductname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtproductname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtproductname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtproductname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproductname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtproductname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtproductname.Location = new System.Drawing.Point(246, 74);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.PasswordChar = '\0';
            this.txtproductname.PlaceholderText = "";
            this.txtproductname.SelectedText = "";
            this.txtproductname.Size = new System.Drawing.Size(273, 36);
            this.txtproductname.TabIndex = 17;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(78, 147);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(99, 20);
            this.description.TabIndex = 16;
            this.description.Text = "Supplier Id";
            // 
            // categoryname
            // 
            this.categoryname.AutoSize = true;
            this.categoryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryname.ForeColor = System.Drawing.Color.Black;
            this.categoryname.Location = new System.Drawing.Point(78, 86);
            this.categoryname.Name = "categoryname";
            this.categoryname.Size = new System.Drawing.Size(128, 20);
            this.categoryname.TabIndex = 15;
            this.categoryname.Text = "Product Name";
            // 
            // txtsupplierid
            // 
            this.txtsupplierid.BackColor = System.Drawing.Color.Transparent;
            this.txtsupplierid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsupplierid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsupplierid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsupplierid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsupplierid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsupplierid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtsupplierid.ItemHeight = 30;
            this.txtsupplierid.Location = new System.Drawing.Point(246, 131);
            this.txtsupplierid.Name = "txtsupplierid";
            this.txtsupplierid.Size = new System.Drawing.Size(273, 36);
            this.txtsupplierid.TabIndex = 18;
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.BackColor = System.Drawing.Color.Transparent;
            this.txtcategoryid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcategoryid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategoryid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategoryid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcategoryid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcategoryid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtcategoryid.ItemHeight = 30;
            this.txtcategoryid.Location = new System.Drawing.Point(246, 197);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.Size = new System.Drawing.Size(273, 36);
            this.txtcategoryid.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Category Id";
            // 
            // txtqtyperunit
            // 
            this.txtqtyperunit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqtyperunit.DefaultText = "";
            this.txtqtyperunit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtqtyperunit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtqtyperunit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqtyperunit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqtyperunit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqtyperunit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtqtyperunit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqtyperunit.Location = new System.Drawing.Point(246, 273);
            this.txtqtyperunit.Name = "txtqtyperunit";
            this.txtqtyperunit.PasswordChar = '\0';
            this.txtqtyperunit.PlaceholderText = "";
            this.txtqtyperunit.SelectedText = "";
            this.txtqtyperunit.Size = new System.Drawing.Size(273, 36);
            this.txtqtyperunit.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Qty Per Unit";
            // 
            // txtdiscontinued
            // 
            this.txtdiscontinued.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiscontinued.DefaultText = "";
            this.txtdiscontinued.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiscontinued.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiscontinued.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiscontinued.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiscontinued.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiscontinued.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiscontinued.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiscontinued.Location = new System.Drawing.Point(246, 606);
            this.txtdiscontinued.Name = "txtdiscontinued";
            this.txtdiscontinued.PasswordChar = '\0';
            this.txtdiscontinued.PlaceholderText = "";
            this.txtdiscontinued.SelectedText = "";
            this.txtdiscontinued.Size = new System.Drawing.Size(273, 36);
            this.txtdiscontinued.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(78, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "UnitsinStock";
            // 
            // txtreorderlevel
            // 
            this.txtreorderlevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreorderlevel.DefaultText = "";
            this.txtreorderlevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtreorderlevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtreorderlevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtreorderlevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtreorderlevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtreorderlevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtreorderlevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtreorderlevel.Location = new System.Drawing.Point(246, 543);
            this.txtreorderlevel.Name = "txtreorderlevel";
            this.txtreorderlevel.PasswordChar = '\0';
            this.txtreorderlevel.PlaceholderText = "";
            this.txtreorderlevel.SelectedText = "";
            this.txtreorderlevel.Size = new System.Drawing.Size(273, 36);
            this.txtreorderlevel.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "UnitsonOrder";
            // 
            // txtunitsonorder
            // 
            this.txtunitsonorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitsonorder.DefaultText = "";
            this.txtunitsonorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtunitsonorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtunitsonorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitsonorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitsonorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitsonorder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtunitsonorder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitsonorder.Location = new System.Drawing.Point(246, 481);
            this.txtunitsonorder.Name = "txtunitsonorder";
            this.txtunitsonorder.PasswordChar = '\0';
            this.txtunitsonorder.PlaceholderText = "";
            this.txtunitsonorder.SelectedText = "";
            this.txtunitsonorder.Size = new System.Drawing.Size(273, 36);
            this.txtunitsonorder.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(78, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ReorderLevel";
            // 
            // txtunitsinstock
            // 
            this.txtunitsinstock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitsinstock.DefaultText = "";
            this.txtunitsinstock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtunitsinstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtunitsinstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitsinstock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitsinstock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitsinstock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtunitsinstock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitsinstock.Location = new System.Drawing.Point(246, 410);
            this.txtunitsinstock.Name = "txtunitsinstock";
            this.txtunitsinstock.PasswordChar = '\0';
            this.txtunitsinstock.PlaceholderText = "";
            this.txtunitsinstock.SelectedText = "";
            this.txtunitsinstock.Size = new System.Drawing.Size(273, 36);
            this.txtunitsinstock.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(76, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Discontinued";
            // 
            // txtunitprice
            // 
            this.txtunitprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitprice.DefaultText = "";
            this.txtunitprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtunitprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtunitprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtunitprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtunitprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtunitprice.Location = new System.Drawing.Point(246, 344);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.PasswordChar = '\0';
            this.txtunitprice.PlaceholderText = "";
            this.txtunitprice.SelectedText = "";
            this.txtunitprice.Size = new System.Drawing.Size(273, 36);
            this.txtunitprice.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(78, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Unit Price";
            // 
            // btnexit
            // 
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(826, 598);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(180, 45);
            this.btnexit.TabIndex = 37;
            this.btnexit.Text = "Exit";
            // 
            // btnshowall
            // 
            this.btnshowall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnshowall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnshowall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnshowall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnshowall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnshowall.ForeColor = System.Drawing.Color.White;
            this.btnshowall.Location = new System.Drawing.Point(960, 497);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(180, 45);
            this.btnshowall.TabIndex = 36;
            this.btnshowall.Text = "Show All";
            // 
            // btndelete
            // 
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(688, 497);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(180, 45);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "Delete";
            // 
            // Update
            // 
            this.Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(965, 376);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(180, 45);
            this.Update.TabIndex = 34;
            this.Update.Text = "Update";
            // 
            // btninsert
            // 
            this.btninsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btninsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btninsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btninsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btninsert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btninsert.ForeColor = System.Drawing.Color.White;
            this.btninsert.Location = new System.Drawing.Point(688, 376);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(180, 45);
            this.btninsert.TabIndex = 33;
            this.btninsert.Text = "Insert";
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // Admin_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtunitsinstock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtunitsonorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtreorderlevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiscontinued);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtqtyperunit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcategoryid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsupplierid);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.description);
            this.Controls.Add(this.categoryname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.resultGrid);
            this.Name = "Admin_Products";
            this.Size = new System.Drawing.Size(1408, 668);
            this.Load += new System.EventHandler(this.Admin_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView resultGrid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txtproductid;
        private Guna.UI2.WinForms.Guna2TextBox txtproductname;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label categoryname;
        private Guna.UI2.WinForms.Guna2ComboBox txtsupplierid;
        private Guna.UI2.WinForms.Guna2ComboBox txtcategoryid;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtqtyperunit;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtdiscontinued;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtreorderlevel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtunitsonorder;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtunitsinstock;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtunitprice;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnshowall;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2Button Update;
        private Guna.UI2.WinForms.Guna2Button btninsert;
    }
}
