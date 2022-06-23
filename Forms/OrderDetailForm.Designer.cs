
namespace Avoda_Managerment.Forms
{
    partial class OrderDetailForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.txt_customer_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_is_new_customer_1 = new System.Windows.Forms.Label();
            this.lbl_is_new_customer_2 = new System.Windows.Forms.Label();
            this.lbl_final_price = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_num_score = new System.Windows.Forms.Label();
            this.txt_num_score = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_score)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_name.Location = new System.Drawing.Point(196, 26);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.ReadOnly = true;
            this.txt_customer_name.Size = new System.Drawing.Size(232, 34);
            this.txt_customer_name.TabIndex = 1;
            this.txt_customer_name.TabStop = false;
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_phone.Location = new System.Drawing.Point(196, 68);
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.ReadOnly = true;
            this.txt_customer_phone.Size = new System.Drawing.Size(232, 34);
            this.txt_customer_phone.TabIndex = 2;
            this.txt_customer_phone.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng hóa đơn:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(27, 141);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(401, 29);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "price";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_is_new_customer_1
            // 
            this.lbl_is_new_customer_1.AutoSize = true;
            this.lbl_is_new_customer_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_is_new_customer_1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_is_new_customer_1.Location = new System.Drawing.Point(22, 175);
            this.lbl_is_new_customer_1.Name = "lbl_is_new_customer_1";
            this.lbl_is_new_customer_1.Size = new System.Drawing.Size(161, 28);
            this.lbl_is_new_customer_1.TabIndex = 12;
            this.lbl_is_new_customer_1.Text = "Số điểm hiện có: ";
            this.lbl_is_new_customer_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_is_new_customer_2
            // 
            this.lbl_is_new_customer_2.AutoSize = true;
            this.lbl_is_new_customer_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_is_new_customer_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_is_new_customer_2.Location = new System.Drawing.Point(22, 270);
            this.lbl_is_new_customer_2.Name = "lbl_is_new_customer_2";
            this.lbl_is_new_customer_2.Size = new System.Drawing.Size(189, 28);
            this.lbl_is_new_customer_2.TabIndex = 13;
            this.lbl_is_new_customer_2.Text = "Hóa đơn sau cùng:";
            this.lbl_is_new_customer_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_final_price
            // 
            this.lbl_final_price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_final_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_final_price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final_price.Location = new System.Drawing.Point(27, 308);
            this.lbl_final_price.Name = "lbl_final_price";
            this.lbl_final_price.Size = new System.Drawing.Size(401, 29);
            this.lbl_final_price.TabIndex = 14;
            this.lbl_final_price.Text = "price";
            this.lbl_final_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_score
            // 
            this.lbl_score.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(196, 175);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(232, 29);
            this.lbl_score.TabIndex = 16;
            this.lbl_score.Text = "score";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.LightGreen;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_confirm.Location = new System.Drawing.Point(27, 353);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(196, 71);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "XÁC NHẬN THANH TOÁN";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Tomato;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cancel.Location = new System.Drawing.Point(233, 353);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(195, 71);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "HỦY THANH TOÁN";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_num_score
            // 
            this.lbl_num_score.AutoSize = true;
            this.lbl_num_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_num_score.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_score.Location = new System.Drawing.Point(22, 221);
            this.lbl_num_score.Name = "lbl_num_score";
            this.lbl_num_score.Size = new System.Drawing.Size(260, 28);
            this.lbl_num_score.TabIndex = 17;
            this.lbl_num_score.Text = "Số điểm sử dụng (1đ = 20k):";
            this.lbl_num_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_num_score
            // 
            this.txt_num_score.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_score.Location = new System.Drawing.Point(333, 219);
            this.txt_num_score.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_num_score.Name = "txt_num_score";
            this.txt_num_score.Size = new System.Drawing.Size(95, 34);
            this.txt_num_score.TabIndex = 18;
            this.txt_num_score.ValueChanged += new System.EventHandler(this.txt_num_score_ValueChanged);
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(456, 442);
            this.Controls.Add(this.txt_num_score);
            this.Controls.Add(this.lbl_num_score);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_final_price);
            this.Controls.Add(this.lbl_is_new_customer_2);
            this.Controls.Add(this.lbl_is_new_customer_1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_customer_name);
            this.Controls.Add(this.txt_customer_phone);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 481);
            this.MinimumSize = new System.Drawing.Size(472, 481);
            this.Name = "OrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customer_name;
        private System.Windows.Forms.TextBox txt_customer_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_is_new_customer_1;
        private System.Windows.Forms.Label lbl_is_new_customer_2;
        private System.Windows.Forms.Label lbl_final_price;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_num_score;
        private System.Windows.Forms.NumericUpDown txt_num_score;
    }
}