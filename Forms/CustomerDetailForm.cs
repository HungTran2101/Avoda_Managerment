using Avoda_Managerment.Models;
using Avoda_Managerment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avoda_Managerment.Forms
{
    public partial class CustomerDetailForm : Form
    {
        private Database myDB;
        private Customer currentCustomer;

        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;

            myDB = Database.getInstance();
        }

        public void loadData(Customer customer)
        {
            currentCustomer = customer;

            lbl_id.Text = customer.Id.ToString();
            txt_name.Text = customer.Name;
            txt_phone.Text = customer.Phone;
            lbl_score.Text = customer.Score.ToString();
        }

        private bool validToSave()
        {
            if (txt_name.Text == currentCustomer.Name && txt_phone.Text == currentCustomer.Phone)
            {
                return false;
            }
            else if (!int.TryParse(txt_phone.Text, out _) || txt_phone.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "CHI TIẾT KHÁCH HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "CHI TIẾT KHÁCH HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            currentCustomer.Name = txt_name.Text;
            currentCustomer.Phone = txt_phone.Text;
            return true;
        }

        #region Event Handlers

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validToSave())
            {
                if (myDB.updateCustomer(currentCustomer))
                {
                    MessageBox.Show("Lưu thông tin thành công", "CHI TIẾT KHÁCH HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        #endregion Event Handlers
    }
}