using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avoda_Managerment.Models;
using Avoda_Managerment.Utils;

namespace Avoda_Managerment.Forms
{
    public partial class BuyTradeForm : Form
    {
        private Database myDB;
        private long totalPrice = 0;

        public BuyTradeForm()
        {
            InitializeComponent();
        }

        private void GiaoDichForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;
            grid_available_product.BackgroundColor = Global.mainColor;
            grid_present_order.BackgroundColor = Global.mainColor;

            myDB = Database.getInstance();

            loadAvailableProduct();
        }

        private void loadAvailableProduct()
        {
            DataTable data = myDB.getAvailableProduct();
            grid_available_product.DataSource = data;
        }

        private long calculateTotalPrice(long price, int quantity, bool isAdd)
        {
            if (isAdd)
                totalPrice += (price * quantity);
            else
                totalPrice -= (price * quantity);

            return totalPrice;
        }

        private bool isOrderExist(int id)
        {
            foreach (DataGridViewRow row in grid_present_order.Rows)
            {
                if (int.Parse(row.Cells["product_id"].Value.ToString()) == id)
                {
                    MessageBox.Show("Vui lòng xóa sản phẩm và thêm lại để thay đổi.", "Sản phẩm đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private bool isInfoValid()
        {
            if (txt_customer_name.Text == "" || txt_customer_phone.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên và số điện thoại khách hàng", "THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!int.TryParse(txt_customer_phone.Text, out _) || txt_customer_phone.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (grid_present_order.RowCount == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm", "THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #region Event Handlers

        private void grid_available_product_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid_available_product.SelectedRows)
            {
                lbl_color.Text = "Màu: " + row.Cells["color"].Value.ToString();
                lbl_price.Text = "Giá: " + Global.currencyToText(long.Parse(row.Cells["price"].Value.ToString()));
                lbl_stock.Text = "Tồn kho: " + row.Cells["stock"].Value.ToString();
                txt_quantity.Maximum = int.Parse(row.Cells["stock"].Value.ToString());
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid_available_product.SelectedRows)
            {
                string type = row.Cells["type"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();
                string size = row.Cells["size"].Value.ToString();
                string color = row.Cells["color"].Value.ToString();
                int quantity = int.Parse(txt_quantity.Value.ToString());
                long price = long.Parse(row.Cells["price"].Value.ToString());
                int id = int.Parse(row.Cells["id"].Value.ToString());

                if (!isOrderExist(id))
                {
                    grid_present_order.Rows.Add(id, type, name, size, color, quantity, price);
                    grid_present_order.Rows[grid_present_order.Rows.Count - 1].Selected = true;
                    lbl_total_price.Text = Global.currencyToText(calculateTotalPrice(price, quantity, true));
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (grid_present_order.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in grid_present_order.SelectedRows)
                {
                    int price = int.Parse(row.Cells["order_price"].Value.ToString());
                    int quantity = int.Parse(row.Cells["order_quantity"].Value.ToString());
                    grid_present_order.Rows.Remove(row);
                    if (grid_present_order.Rows.Count != 0)
                        grid_present_order.Rows[grid_present_order.Rows.Count - 1].Selected = true;
                    lbl_total_price.Text = Global.currencyToText(calculateTotalPrice(price, quantity, false));
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadAvailableProduct();

            txt_customer_name.Clear();
            txt_customer_phone.Clear();
            txt_quantity.Value = txt_quantity.Minimum;
            grid_present_order.Rows.Clear();
            grid_present_order.Refresh();
            totalPrice = 0;
            lbl_total_price.Text = Global.currencyToText(totalPrice);
        }

        private void btn_deal_Click(object sender, EventArgs e)
        {
            if (isInfoValid())
            {
                Customer customer = new Customer
                {
                    Name = txt_customer_name.Text,
                    Phone = txt_customer_phone.Text
                };
                DataTable result = myDB.getCustomerByPhone(customer.Phone);
                if (result.Rows.Count > 0)
                {
                    customer.Id = int.Parse(result.Rows[0]["id"].ToString());
                    customer.Score = int.Parse(result.Rows[0]["score"].ToString());
                }
                else
                {
                    customer.Score = -1;
                }

                using (OrderDetailForm frm = new OrderDetailForm())
                {
                    frm.loadData(customer, totalPrice, grid_present_order);
                    DialogResult rs = frm.ShowDialog(this);
                    if (rs == DialogResult.OK)
                    {
                        btn_refresh.PerformClick();
                    }
                }
            }
        }

        private void txt_customer_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_customer_phone.Text.Length >= 10)
            {
                DataTable customer = myDB.getCustomerByPhone(txt_customer_phone.Text);
                if (customer.Rows.Count > 0)
                {
                    txt_customer_name.Text = customer.Rows[0]["name"].ToString();
                }
                else
                {
                    txt_customer_name.Clear();
                }
            }
        }

        #endregion Event Handlers
    }
}