
namespace Avoda_Managerment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Pnl_nav = new System.Windows.Forms.Panel();
            this.btn_transaction_form = new System.Windows.Forms.Button();
            this.btn_customer_form = new System.Windows.Forms.Button();
            this.btn_stock_form = new System.Windows.Forms.Button();
            this.btn_buy_form = new System.Windows.Forms.Button();
            this.Pnl_logo = new System.Windows.Forms.Panel();
            this.Pnl_title = new System.Windows.Forms.Panel();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Lbl_brandName = new System.Windows.Forms.Label();
            this.Lbl_brandSubTitle1 = new System.Windows.Forms.Label();
            this.Lbl_brandSubTitle2 = new System.Windows.Forms.Label();
            this.Pnl_mainSection = new System.Windows.Forms.Panel();
            this.Pnl_nav.SuspendLayout();
            this.Pnl_title.SuspendLayout();
            this.Pnl_mainSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nav
            // 
            this.Pnl_nav.BackColor = System.Drawing.Color.DimGray;
            this.Pnl_nav.Controls.Add(this.btn_transaction_form);
            this.Pnl_nav.Controls.Add(this.btn_customer_form);
            this.Pnl_nav.Controls.Add(this.btn_stock_form);
            this.Pnl_nav.Controls.Add(this.btn_buy_form);
            this.Pnl_nav.Controls.Add(this.Pnl_logo);
            this.Pnl_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_nav.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nav.Name = "Pnl_nav";
            this.Pnl_nav.Size = new System.Drawing.Size(224, 761);
            this.Pnl_nav.TabIndex = 0;
            // 
            // btn_transaction_form
            // 
            this.btn_transaction_form.BackColor = System.Drawing.Color.Transparent;
            this.btn_transaction_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transaction_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_transaction_form.FlatAppearance.BorderSize = 0;
            this.btn_transaction_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transaction_form.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaction_form.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_transaction_form.Image = global::Avoda_Managerment.Properties.Resources.icons8_history_36;
            this.btn_transaction_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transaction_form.Location = new System.Drawing.Point(0, 340);
            this.btn_transaction_form.Margin = new System.Windows.Forms.Padding(0);
            this.btn_transaction_form.Name = "btn_transaction_form";
            this.btn_transaction_form.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_transaction_form.Size = new System.Drawing.Size(224, 80);
            this.btn_transaction_form.TabIndex = 4;
            this.btn_transaction_form.Tag = "4";
            this.btn_transaction_form.Text = " Lịch sử";
            this.btn_transaction_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_transaction_form.UseVisualStyleBackColor = false;
            this.btn_transaction_form.Click += new System.EventHandler(this.Btn_lichSu_Click);
            // 
            // btn_customer_form
            // 
            this.btn_customer_form.BackColor = System.Drawing.Color.Transparent;
            this.btn_customer_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customer_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer_form.FlatAppearance.BorderSize = 0;
            this.btn_customer_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_form.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_form.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_customer_form.Image = global::Avoda_Managerment.Properties.Resources.round_people_white_36dp;
            this.btn_customer_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer_form.Location = new System.Drawing.Point(0, 260);
            this.btn_customer_form.Margin = new System.Windows.Forms.Padding(0);
            this.btn_customer_form.Name = "btn_customer_form";
            this.btn_customer_form.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_customer_form.Size = new System.Drawing.Size(224, 80);
            this.btn_customer_form.TabIndex = 3;
            this.btn_customer_form.Tag = "2";
            this.btn_customer_form.Text = " Khách hàng";
            this.btn_customer_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customer_form.UseVisualStyleBackColor = false;
            this.btn_customer_form.Click += new System.EventHandler(this.Btn_khachHang_Click);
            // 
            // btn_stock_form
            // 
            this.btn_stock_form.BackColor = System.Drawing.Color.Transparent;
            this.btn_stock_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stock_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stock_form.FlatAppearance.BorderSize = 0;
            this.btn_stock_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock_form.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock_form.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_stock_form.Image = global::Avoda_Managerment.Properties.Resources.round_inventory_2_white_36dp;
            this.btn_stock_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock_form.Location = new System.Drawing.Point(0, 180);
            this.btn_stock_form.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stock_form.Name = "btn_stock_form";
            this.btn_stock_form.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_stock_form.Size = new System.Drawing.Size(224, 80);
            this.btn_stock_form.TabIndex = 2;
            this.btn_stock_form.Tag = "3";
            this.btn_stock_form.Text = " Tồn kho";
            this.btn_stock_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stock_form.UseVisualStyleBackColor = false;
            this.btn_stock_form.Click += new System.EventHandler(this.Btn_tonKho_Click);
            // 
            // btn_buy_form
            // 
            this.btn_buy_form.BackColor = System.Drawing.Color.Transparent;
            this.btn_buy_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buy_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buy_form.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_buy_form.FlatAppearance.BorderSize = 0;
            this.btn_buy_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy_form.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy_form.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buy_form.Image = global::Avoda_Managerment.Properties.Resources.round_shopping_bag_white_36dp;
            this.btn_buy_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy_form.Location = new System.Drawing.Point(0, 100);
            this.btn_buy_form.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buy_form.Name = "btn_buy_form";
            this.btn_buy_form.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_buy_form.Size = new System.Drawing.Size(224, 80);
            this.btn_buy_form.TabIndex = 1;
            this.btn_buy_form.Tag = "1";
            this.btn_buy_form.Text = " Giao dịch";
            this.btn_buy_form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buy_form.UseVisualStyleBackColor = false;
            this.btn_buy_form.Click += new System.EventHandler(this.Btn_giaoDich_Click);
            // 
            // Pnl_logo
            // 
            this.Pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(127)))), ((int)(((byte)(117)))));
            this.Pnl_logo.BackgroundImage = global::Avoda_Managerment.Properties.Resources.avoda_logo;
            this.Pnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_logo.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_logo.Name = "Pnl_logo";
            this.Pnl_logo.Size = new System.Drawing.Size(224, 100);
            this.Pnl_logo.TabIndex = 0;
            // 
            // Pnl_title
            // 
            this.Pnl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(127)))), ((int)(((byte)(117)))));
            this.Pnl_title.Controls.Add(this.Btn_cancel);
            this.Pnl_title.Controls.Add(this.Lbl_title);
            this.Pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_title.Location = new System.Drawing.Point(224, 0);
            this.Pnl_title.Margin = new System.Windows.Forms.Padding(0);
            this.Pnl_title.Name = "Pnl_title";
            this.Pnl_title.Padding = new System.Windows.Forms.Padding(1);
            this.Pnl_title.Size = new System.Drawing.Size(1160, 100);
            this.Pnl_title.TabIndex = 1;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_cancel.FlatAppearance.BorderSize = 0;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_cancel.Image = global::Avoda_Managerment.Properties.Resources.icons8_back_36;
            this.Btn_cancel.Location = new System.Drawing.Point(1, 1);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(35, 98);
            this.Btn_cancel.TabIndex = 5;
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Lbl_title
            // 
            this.Lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_title.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_title.Location = new System.Drawing.Point(1, 1);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(1158, 98);
            this.Lbl_title.TabIndex = 0;
            this.Lbl_title.Text = "Trang chủ";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_brandName
            // 
            this.Lbl_brandName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_brandName.AutoSize = true;
            this.Lbl_brandName.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_brandName.Font = new System.Drawing.Font("Perpetua", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_brandName.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbl_brandName.Location = new System.Drawing.Point(260, 284);
            this.Lbl_brandName.Name = "Lbl_brandName";
            this.Lbl_brandName.Size = new System.Drawing.Size(622, 77);
            this.Lbl_brandName.TabIndex = 1;
            this.Lbl_brandName.Text = "A V O D A . S T O R E";
            // 
            // Lbl_brandSubTitle1
            // 
            this.Lbl_brandSubTitle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_brandSubTitle1.AutoSize = true;
            this.Lbl_brandSubTitle1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_brandSubTitle1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_brandSubTitle1.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_brandSubTitle1.Location = new System.Drawing.Point(464, 236);
            this.Lbl_brandSubTitle1.Name = "Lbl_brandSubTitle1";
            this.Lbl_brandSubTitle1.Size = new System.Drawing.Size(241, 27);
            this.Lbl_brandSubTitle1.TabIndex = 2;
            this.Lbl_brandSubTitle1.Text = "WOMAN FASHION";
            // 
            // Lbl_brandSubTitle2
            // 
            this.Lbl_brandSubTitle2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_brandSubTitle2.AutoSize = true;
            this.Lbl_brandSubTitle2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_brandSubTitle2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_brandSubTitle2.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_brandSubTitle2.Location = new System.Drawing.Point(456, 386);
            this.Lbl_brandSubTitle2.Name = "Lbl_brandSubTitle2";
            this.Lbl_brandSubTitle2.Size = new System.Drawing.Size(253, 27);
            this.Lbl_brandSubTitle2.TabIndex = 3;
            this.Lbl_brandSubTitle2.Text = "MADE IN VIETNAM";
            // 
            // Pnl_mainSection
            // 
            this.Pnl_mainSection.AutoScroll = true;
            this.Pnl_mainSection.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_mainSection.Controls.Add(this.Lbl_brandSubTitle1);
            this.Pnl_mainSection.Controls.Add(this.Lbl_brandSubTitle2);
            this.Pnl_mainSection.Controls.Add(this.Lbl_brandName);
            this.Pnl_mainSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_mainSection.Location = new System.Drawing.Point(224, 100);
            this.Pnl_mainSection.Name = "Pnl_mainSection";
            this.Pnl_mainSection.Size = new System.Drawing.Size(1160, 661);
            this.Pnl_mainSection.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.Pnl_mainSection);
            this.Controls.Add(this.Pnl_title);
            this.Controls.Add(this.Pnl_nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Pnl_nav.ResumeLayout(false);
            this.Pnl_title.ResumeLayout(false);
            this.Pnl_mainSection.ResumeLayout(false);
            this.Pnl_mainSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nav;
        private System.Windows.Forms.Panel Pnl_logo;
        private System.Windows.Forms.Button btn_buy_form;
        private System.Windows.Forms.Button btn_customer_form;
        private System.Windows.Forms.Button btn_stock_form;
        private System.Windows.Forms.Panel Pnl_title;
        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Label Lbl_brandName;
        private System.Windows.Forms.Label Lbl_brandSubTitle1;
        private System.Windows.Forms.Label Lbl_brandSubTitle2;
        private System.Windows.Forms.Panel Pnl_mainSection;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button btn_transaction_form;
    }
}