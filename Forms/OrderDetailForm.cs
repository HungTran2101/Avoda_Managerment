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
    public partial class OrderDetailForm : Form
    {
        private Database myDB;
        private DataGridView currentOrder;
        private Customer currentCustomer;

        public OrderDetailForm()
        {
            InitializeComponent();
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;

            myDB = Database.getInstance();
        }

        public void loadData(Customer currentCustomer, long price, DataGridView currentOrder)
        {
            if (currentCustomer.Score == -1)
            {
                txt_num_score.Maximum = 0;
                txt_num_score.Visible = false;
                lbl_score.Visible = false;
                lbl_is_new_customer_2.Visible = false;
                lbl_final_price.Visible = false;
                lbl_num_score.Visible = false;
                lbl_is_new_customer_1.Text = "Khách hàng mới!";
            }
            else
            {
                txt_num_score.Maximum = currentCustomer.Score;
            }

            txt_customer_name.Text = currentCustomer.Name;
            txt_customer_phone.Text = currentCustomer.Phone;
            lbl_score.Text = currentCustomer.Score.ToString();
            lbl_total.Text = Global.currencyToText(price);
            lbl_final_price.Text = Global.currencyToText(price);

            this.currentOrder = currentOrder;
            this.currentCustomer = currentCustomer;
        }

        private void addNewCustomer()
        {
            myDB.addCustomer(currentCustomer);

            // get id of the customer added above
            DataTable tempCustomer = myDB.getCustomerByPhone(currentCustomer.Phone);
            currentCustomer.Id = int.Parse(tempCustomer.Rows[0]["id"].ToString());
        }

        private int addTransaction(int score_earn)
        {
            myDB.addTransaction(currentCustomer.Id,
                Global.textToCurrency(lbl_total.Text),
                int.Parse(txt_num_score.Value.ToString()),
                Global.textToCurrency(lbl_final_price.Text),
                score_earn,
                DateTime.Now);

            //return the id of transaction added above
            return int.Parse(myDB.getLastTransaction().Rows[0]["id"].ToString());
        }

        private void addDetailTransaction(int transaction_id)
        {
            foreach (DataGridViewRow row in currentOrder.Rows)
            {
                myDB.updateStock(int.Parse(row.Cells["product_id"].Value.ToString()), int.Parse(row.Cells["order_quantity"].Value.ToString()));
                myDB.addDetailTransaction(transaction_id, int.Parse(row.Cells["product_id"].Value.ToString()), int.Parse(row.Cells["order_quantity"].Value.ToString()));
            }
        }

        private int updateCustomerScore()
        {
            return myDB.updateCustomerScore(int.Parse(txt_num_score.Value.ToString()),
                Global.textToCurrency(lbl_final_price.Text),
                currentCustomer.Id);
        }

        #region Event Handlers

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thanh toán?", "THANH TOÁN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (currentCustomer.Score == -1) //new customer
                {
                    addNewCustomer();
                }
                int score_earn = updateCustomerScore();
                int transaction_id = addTransaction(score_earn);
                addDetailTransaction(transaction_id);

                MessageBox.Show("Lưu giao dịch thành công!", "GIAO DỊCH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_num_score_ValueChanged(object sender, EventArgs e)
        {
            long currentTotal = Global.textToCurrency(lbl_total.Text);
            long score = long.Parse(txt_num_score.Value.ToString());
            currentTotal -= score * Global.scoreToPrice;
            lbl_final_price.Text = Global.currencyToText(currentTotal);
        }

        #endregion Event Handlers
    }
}