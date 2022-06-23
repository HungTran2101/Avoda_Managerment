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
    public partial class ProductDetailForm : Form
    {
        private Database myDB;
        private Product currentProduct;

        public ProductDetailForm()
        {
            InitializeComponent();
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;

            myDB = Database.getInstance();

            if (!isProductTransacted()) //Disable delete button if product was transacted
            {
                foreach (RowStyle row in tpnl_btns.RowStyles)
                {
                    if (row.SizeType == SizeType.Percent)
                    {
                        row.Height = 33.33F;
                    }
                    else if (row.SizeType == SizeType.Absolute)
                    {
                        row.SizeType = SizeType.Percent;
                        row.Height = 33.33F;
                    }
                }
            }
        }

        public void loadData(Product input)
        {
            currentProduct = input;

            txt_type.Text = input.Type;
            txt_name.Text = input.Name;
            txt_stock.Value = input.Stock;
            txt_size.Text = input.Size;
            txt_price.Text = input.Price.ToString();
            txt_color.Text = input.Color;
        }

        private bool isProductTransacted()
        {
            DataTable data = myDB.getProductTransaction(currentProduct.Id);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private bool validToSave()
        {
            if ((txt_price.Value != currentProduct.Price) || (txt_stock.Value != currentProduct.Stock))
            {
                return true;
            }
            return false;
        }

        #region Event Handlers

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validToSave())
            {
                currentProduct.Stock = int.Parse(txt_stock.Value.ToString());
                currentProduct.Price = long.Parse(txt_price.Value.ToString());
                if (myDB.updateProduct(currentProduct))
                {
                    MessageBox.Show("Lưu sản phẩm thành công!", "TỒN KHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn muốn xóa sản phẩm \"" + currentProduct.Name + "\" này?", "CHI TIẾT SẢN PHẨM",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (myDB.deleteProductById(currentProduct.Id))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "TỒN KHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Event Handlers
    }
}