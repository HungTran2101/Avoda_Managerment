
namespace Avoda_Managerment.Forms
{
    partial class BuyTradeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.groupBoxGuestInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.txt_customer_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.grid_available_product = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_deal = new System.Windows.Forms.Button();
            this.grid_present_order = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGiaoDich = new System.Windows.Forms.Panel();
            this.groupBoxGuestInfo.SuspendLayout();
            this.groupBoxProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_available_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_present_order)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlGiaoDich.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_product
            // 
            this.btn_add_product.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_add_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_product.FlatAppearance.BorderSize = 0;
            this.btn_add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_product.Location = new System.Drawing.Point(159, 438);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(182, 56);
            this.btn_add_product.TabIndex = 3;
            this.btn_add_product.Text = "THÊM SẢN PHẨM";
            this.btn_add_product.UseVisualStyleBackColor = false;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // groupBoxGuestInfo
            // 
            this.groupBoxGuestInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxGuestInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGuestInfo.Controls.Add(this.label3);
            this.groupBoxGuestInfo.Controls.Add(this.txt_customer_name);
            this.groupBoxGuestInfo.Controls.Add(this.txt_customer_phone);
            this.groupBoxGuestInfo.Controls.Add(this.label1);
            this.groupBoxGuestInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGuestInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGuestInfo.Name = "groupBoxGuestInfo";
            this.groupBoxGuestInfo.Size = new System.Drawing.Size(357, 122);
            this.groupBoxGuestInfo.TabIndex = 7;
            this.groupBoxGuestInfo.TabStop = false;
            this.groupBoxGuestInfo.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_name.Location = new System.Drawing.Point(173, 73);
            this.txt_customer_name.MaxLength = 50;
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.Size = new System.Drawing.Size(169, 27);
            this.txt_customer_name.TabIndex = 2;
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_phone.Location = new System.Drawing.Point(173, 41);
            this.txt_customer_phone.MaxLength = 11;
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.Size = new System.Drawing.Size(169, 27);
            this.txt_customer_phone.TabIndex = 1;
            this.txt_customer_phone.TextChanged += new System.EventHandler(this.txt_customer_phone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng:";
            // 
            // groupBoxProductInfo
            // 
            this.groupBoxProductInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProductInfo.Controls.Add(this.lbl_price);
            this.groupBoxProductInfo.Controls.Add(this.lbl_stock);
            this.groupBoxProductInfo.Controls.Add(this.lbl_color);
            this.groupBoxProductInfo.Controls.Add(this.grid_available_product);
            this.groupBoxProductInfo.Controls.Add(this.btn_refresh);
            this.groupBoxProductInfo.Controls.Add(this.txt_quantity);
            this.groupBoxProductInfo.Controls.Add(this.btn_add_product);
            this.groupBoxProductInfo.Controls.Add(this.label7);
            this.groupBoxProductInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductInfo.Location = new System.Drawing.Point(12, 140);
            this.groupBoxProductInfo.Name = "groupBoxProductInfo";
            this.groupBoxProductInfo.Size = new System.Drawing.Size(357, 509);
            this.groupBoxProductInfo.TabIndex = 8;
            this.groupBoxProductInfo.TabStop = false;
            this.groupBoxProductInfo.Text = "Sản phẩm hiện có";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(15, 341);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(45, 28);
            this.lbl_price.TabIndex = 20;
            this.lbl_price.Text = "Giá:";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(15, 292);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(87, 28);
            this.lbl_stock.TabIndex = 19;
            this.lbl_stock.Text = "Tồn kho:";
            this.lbl_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_color.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(159, 292);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(55, 28);
            this.lbl_color.TabIndex = 18;
            this.lbl_color.Text = "Màu:";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_available_product
            // 
            this.grid_available_product.AllowUserToAddRows = false;
            this.grid_available_product.AllowUserToDeleteRows = false;
            this.grid_available_product.AllowUserToResizeRows = false;
            this.grid_available_product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_available_product.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid_available_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_available_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_available_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_available_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.name,
            this.size,
            this.color,
            this.stock,
            this.price});
            this.grid_available_product.Location = new System.Drawing.Point(20, 32);
            this.grid_available_product.MultiSelect = false;
            this.grid_available_product.Name = "grid_available_product";
            this.grid_available_product.ReadOnly = true;
            this.grid_available_product.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_available_product.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_available_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_available_product.Size = new System.Drawing.Size(321, 257);
            this.grid_available_product.TabIndex = 16;
            this.grid_available_product.TabStop = false;
            this.grid_available_product.SelectionChanged += new System.EventHandler(this.grid_available_product_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 54;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.type.DefaultCellStyle = dataGridViewCellStyle2;
            this.type.HeaderText = "Loại";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 75;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 138;
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 53;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Visible = false;
            this.color.Width = 5;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            this.stock.Width = 5;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Visible = false;
            this.price.Width = 5;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_refresh.Location = new System.Drawing.Point(20, 438);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(133, 56);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "LÀM MỚI";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(132, 392);
            this.txt_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.Size = new System.Drawing.Size(51, 34);
            this.txt_quantity.TabIndex = 14;
            this.txt_quantity.TabStop = false;
            this.txt_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số lượng:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_deal
            // 
            this.btn_deal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deal.BackColor = System.Drawing.Color.LightGreen;
            this.btn_deal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deal.FlatAppearance.BorderSize = 0;
            this.btn_deal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_deal.Location = new System.Drawing.Point(519, 536);
            this.btn_deal.Name = "btn_deal";
            this.btn_deal.Size = new System.Drawing.Size(113, 92);
            this.btn_deal.TabIndex = 5;
            this.btn_deal.Text = "THANH TOÁN";
            this.btn_deal.UseVisualStyleBackColor = false;
            this.btn_deal.Click += new System.EventHandler(this.btn_deal_Click);
            // 
            // grid_present_order
            // 
            this.grid_present_order.AllowUserToAddRows = false;
            this.grid_present_order.AllowUserToDeleteRows = false;
            this.grid_present_order.AllowUserToResizeRows = false;
            this.grid_present_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_present_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_present_order.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grid_present_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_present_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_present_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_present_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.order_type,
            this.order_name,
            this.order_size,
            this.order_color,
            this.order_quantity,
            this.order_price});
            this.grid_present_order.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_present_order.Location = new System.Drawing.Point(3, 30);
            this.grid_present_order.MultiSelect = false;
            this.grid_present_order.Name = "grid_present_order";
            this.grid_present_order.ReadOnly = true;
            this.grid_present_order.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_present_order.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_present_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_present_order.Size = new System.Drawing.Size(637, 492);
            this.grid_present_order.TabIndex = 0;
            this.grid_present_order.TabStop = false;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "id";
            this.product_id.HeaderText = "Mã";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 67;
            // 
            // order_type
            // 
            this.order_type.DataPropertyName = "type";
            this.order_type.HeaderText = "Loại";
            this.order_type.Name = "order_type";
            this.order_type.ReadOnly = true;
            this.order_type.Width = 76;
            // 
            // order_name
            // 
            this.order_name.DataPropertyName = "name";
            this.order_name.HeaderText = "Tên";
            this.order_name.Name = "order_name";
            this.order_name.ReadOnly = true;
            this.order_name.Width = 70;
            // 
            // order_size
            // 
            this.order_size.DataPropertyName = "size";
            this.order_size.HeaderText = "Size";
            this.order_size.Name = "order_size";
            this.order_size.ReadOnly = true;
            this.order_size.Width = 75;
            // 
            // order_color
            // 
            this.order_color.DataPropertyName = "color";
            this.order_color.HeaderText = "Màu";
            this.order_color.Name = "order_color";
            this.order_color.ReadOnly = true;
            this.order_color.Width = 79;
            // 
            // order_quantity
            // 
            this.order_quantity.DataPropertyName = "quantity";
            this.order_quantity.HeaderText = "Số lượng";
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.ReadOnly = true;
            this.order_quantity.Width = 122;
            // 
            // order_price
            // 
            this.order_price.DataPropertyName = "price";
            this.order_price.HeaderText = "Giá";
            this.order_price.Name = "order_price";
            this.order_price.ReadOnly = true;
            this.order_price.Width = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_total_price);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_deal);
            this.groupBox1.Controls.Add(this.grid_present_order);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(375, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 637);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn hàng hiện tại";
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_price.Location = new System.Drawing.Point(6, 580);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(74, 28);
            this.lbl_total_price.TabIndex = 22;
            this.lbl_total_price.Text = "0 VND";
            this.lbl_total_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(444, 536);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 92);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "XÓA SẢN PHẨM";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tổng cần thanh toán:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGiaoDich
            // 
            this.pnlGiaoDich.AutoScroll = true;
            this.pnlGiaoDich.Controls.Add(this.groupBox1);
            this.pnlGiaoDich.Controls.Add(this.groupBoxGuestInfo);
            this.pnlGiaoDich.Controls.Add(this.groupBoxProductInfo);
            this.pnlGiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiaoDich.Location = new System.Drawing.Point(0, 0);
            this.pnlGiaoDich.Name = "pnlGiaoDich";
            this.pnlGiaoDich.Size = new System.Drawing.Size(1031, 661);
            this.pnlGiaoDich.TabIndex = 11;
            // 
            // BuyTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1031, 661);
            this.Controls.Add(this.pnlGiaoDich);
            this.Name = "BuyTradeForm";
            this.Text = "Giao dịch/Đổi trả";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GiaoDichForm_Load);
            this.groupBoxGuestInfo.ResumeLayout(false);
            this.groupBoxGuestInfo.PerformLayout();
            this.groupBoxProductInfo.ResumeLayout(false);
            this.groupBoxProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_available_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_present_order)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlGiaoDich.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.GroupBox groupBoxGuestInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customer_name;
        private System.Windows.Forms.TextBox txt_customer_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxProductInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.DataGridView grid_present_order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlGiaoDich;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView grid_available_product;
        private System.Windows.Forms.Button btn_deal;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
    }
}