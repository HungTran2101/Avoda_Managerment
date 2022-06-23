
namespace Avoda_Managerment.Forms
{
    partial class StockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new System.Windows.Forms.Button();
            this.grid_stock = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.NumericUpDown();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.NumericUpDown();
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.rbtn_size_s = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn_size_m = new System.Windows.Forms.RadioButton();
            this.rbtn_size_l = new System.Windows.Forms.RadioButton();
            this.rbtn_size_xl = new System.Windows.Forms.RadioButton();
            this.rbtn_size_xxl = new System.Windows.Forms.RadioButton();
            this.rbtn_size_all = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(839, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 69);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "THÊM SẢN PHẨM";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grid_stock
            // 
            this.grid_stock.AllowUserToAddRows = false;
            this.grid_stock.AllowUserToDeleteRows = false;
            this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.name,
            this.color,
            this.size,
            this.stock,
            this.price,
            this.btn_edit});
            this.grid_stock.Location = new System.Drawing.Point(12, 182);
            this.grid_stock.MultiSelect = false;
            this.grid_stock.Name = "grid_stock";
            this.grid_stock.ReadOnly = true;
            this.grid_stock.RowHeadersVisible = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_stock.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_stock.Size = new System.Drawing.Size(1007, 467);
            this.grid_stock.TabIndex = 3;
            this.grid_stock.TabStop = false;
            this.grid_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_stock_CellContentClick);
            this.grid_stock.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_stock_CellMouseEnter);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 65;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Loại";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 74;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 68;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Màu";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 77;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 72;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Tồn kho";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 111;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 66;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.btn_edit.DefaultCellStyle = dataGridViewCellStyle14;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.HeaderText = "";
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ReadOnly = true;
            this.btn_edit.Text = "Chỉnh sửa";
            this.btn_edit.UseColumnTextForButtonValue = true;
            this.btn_edit.Width = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_color);
            this.groupBox1.Controls.Add(this.txt_size);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_price.Location = new System.Drawing.Point(681, 31);
            this.txt_price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_price.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(137, 30);
            this.txt_price.TabIndex = 5;
            this.txt_price.ThousandsSeparator = true;
            this.txt_price.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(681, 69);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(137, 30);
            this.txt_color.TabIndex = 6;
            // 
            // txt_size
            // 
            this.txt_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_size.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.FormattingEnabled = true;
            this.txt_size.Location = new System.Drawing.Point(500, 69);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(99, 31);
            this.txt_size.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(114, 69);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(282, 30);
            this.txt_name.TabIndex = 2;
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(500, 31);
            this.txt_stock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_stock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(99, 30);
            this.txt_stock.TabIndex = 3;
            this.txt_stock.ThousandsSeparator = true;
            this.txt_stock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Location = new System.Drawing.Point(114, 30);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(282, 31);
            this.txt_type.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tồn kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(624, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Màu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(128, 136);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(351, 33);
            this.txt_search.TabIndex = 10;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // rbtn_size_s
            // 
            this.rbtn_size_s.AutoSize = true;
            this.rbtn_size_s.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_size_s.Location = new System.Drawing.Point(543, 140);
            this.rbtn_size_s.Name = "rbtn_size_s";
            this.rbtn_size_s.Size = new System.Drawing.Size(37, 25);
            this.rbtn_size_s.TabIndex = 12;
            this.rbtn_size_s.Text = "S";
            this.rbtn_size_s.UseVisualStyleBackColor = true;
            this.rbtn_size_s.CheckedChanged += new System.EventHandler(this.rbtn_size_s_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Size:";
            // 
            // rbtn_size_m
            // 
            this.rbtn_size_m.AutoSize = true;
            this.rbtn_size_m.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_size_m.Location = new System.Drawing.Point(586, 140);
            this.rbtn_size_m.Name = "rbtn_size_m";
            this.rbtn_size_m.Size = new System.Drawing.Size(43, 25);
            this.rbtn_size_m.TabIndex = 14;
            this.rbtn_size_m.Text = "M";
            this.rbtn_size_m.UseVisualStyleBackColor = true;
            this.rbtn_size_m.CheckedChanged += new System.EventHandler(this.rbtn_size_m_CheckedChanged);
            // 
            // rbtn_size_l
            // 
            this.rbtn_size_l.AutoSize = true;
            this.rbtn_size_l.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_size_l.Location = new System.Drawing.Point(635, 140);
            this.rbtn_size_l.Name = "rbtn_size_l";
            this.rbtn_size_l.Size = new System.Drawing.Size(36, 25);
            this.rbtn_size_l.TabIndex = 15;
            this.rbtn_size_l.Text = "L";
            this.rbtn_size_l.UseVisualStyleBackColor = true;
            this.rbtn_size_l.CheckedChanged += new System.EventHandler(this.rbtn_size_l_CheckedChanged);
            // 
            // rbtn_size_xl
            // 
            this.rbtn_size_xl.AutoSize = true;
            this.rbtn_size_xl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_size_xl.Location = new System.Drawing.Point(677, 140);
            this.rbtn_size_xl.Name = "rbtn_size_xl";
            this.rbtn_size_xl.Size = new System.Drawing.Size(46, 25);
            this.rbtn_size_xl.TabIndex = 16;
            this.rbtn_size_xl.Text = "XL";
            this.rbtn_size_xl.UseVisualStyleBackColor = true;
            this.rbtn_size_xl.CheckedChanged += new System.EventHandler(this.rbtn_size_xl_CheckedChanged);
            // 
            // rbtn_size_xxl
            // 
            this.rbtn_size_xxl.AutoSize = true;
            this.rbtn_size_xxl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_size_xxl.Location = new System.Drawing.Point(729, 140);
            this.rbtn_size_xxl.Name = "rbtn_size_xxl";
            this.rbtn_size_xxl.Size = new System.Drawing.Size(56, 25);
            this.rbtn_size_xxl.TabIndex = 17;
            this.rbtn_size_xxl.Text = "XXL";
            this.rbtn_size_xxl.UseVisualStyleBackColor = true;
            this.rbtn_size_xxl.CheckedChanged += new System.EventHandler(this.rbtn_size_xxl_CheckedChanged);
            // 
            // rbtn_size_all
            // 
            this.rbtn_size_all.AutoSize = true;
            this.rbtn_size_all.Checked = true;
            this.rbtn_size_all.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_size_all.Location = new System.Drawing.Point(791, 140);
            this.rbtn_size_all.Name = "rbtn_size_all";
            this.rbtn_size_all.Size = new System.Drawing.Size(102, 25);
            this.rbtn_size_all.TabIndex = 18;
            this.rbtn_size_all.TabStop = true;
            this.rbtn_size_all.Text = "Tất cả size";
            this.rbtn_size_all.UseVisualStyleBackColor = true;
            this.rbtn_size_all.CheckedChanged += new System.EventHandler(this.rbtn_size_all_CheckedChanged);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1031, 661);
            this.Controls.Add(this.rbtn_size_all);
            this.Controls.Add(this.rbtn_size_xxl);
            this.Controls.Add(this.rbtn_size_xl);
            this.Controls.Add(this.rbtn_size_l);
            this.Controls.Add(this.rbtn_size_m);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbtn_size_s);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_stock);
            this.Name = "StockForm";
            this.Text = "Tồn Kho";
            this.Load += new System.EventHandler(this.TonKhoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView grid_stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.ComboBox txt_size;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown txt_stock;
        private System.Windows.Forms.ComboBox txt_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn btn_edit;
        private System.Windows.Forms.NumericUpDown txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.RadioButton rbtn_size_s;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtn_size_m;
        private System.Windows.Forms.RadioButton rbtn_size_l;
        private System.Windows.Forms.RadioButton rbtn_size_xl;
        private System.Windows.Forms.RadioButton rbtn_size_xxl;
        private System.Windows.Forms.RadioButton rbtn_size_all;
    }
}