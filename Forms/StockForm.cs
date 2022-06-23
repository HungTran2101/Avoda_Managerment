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
    public partial class StockForm : Form
    {
        private Database myDB;
        private DataTable productData;

        public StockForm()
        {
            InitializeComponent();
        }

        private void TonKhoForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;
            grid_stock.BackgroundColor = Global.mainColor;

            myDB = Database.getInstance();

            txt_size.Items.AddRange(Global.sizes);

            loadAllProduct();
            loadProductType();
        }

        private void loadProductType()
        {
            DataTable data = myDB.getAllProductType();
            txt_type.DataSource = data;
            txt_type.DisplayMember = "type";
            txt_type.ValueMember = "type";
        }

        private void loadAllProduct()
        {
            productData = myDB.getAllProduct();
            grid_stock.DataSource = productData;
            resizeGridView();
        }

        private void resizeGridView()
        {
            int total_width = 0;
            foreach (DataGridViewColumn col in grid_stock.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                total_width += col.Width;
            }
            if (total_width < grid_stock.Width)
            {
                grid_stock.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private bool validToAdd()
        {
            if (string.IsNullOrWhiteSpace(txt_type.Text)
                || string.IsNullOrWhiteSpace(txt_name.Text)
                || string.IsNullOrWhiteSpace(txt_color.Text)
                || txt_size.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void refreshForm()
        {
            loadAllProduct();

            txt_type.SelectedIndex = 0;
            txt_name.Clear();
            txt_size.SelectedIndex = -1;
            txt_stock.Value = txt_stock.Minimum;
            txt_color.Clear();
            txt_price.Value = txt_price.Minimum;
        }

        private void filterData(string size, string search)
        {
            DataView temp = new DataView(productData)
            {
                RowFilter = "size IN (" + size + ") AND (" +
                    "type LIKE '%" + search + "%' OR " +
                    "name LIKE '%" + search + "%' OR " +
                    "color LIKE '%" + search + "%')"
            };
            grid_stock.DataSource = temp;
            resizeGridView();
        }

        #region Event Handlers

        private void grid_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = senderGrid.Rows[e.RowIndex];

                Product currentProduct = new Product
                {
                    Id = int.Parse(currentRow.Cells["id"].Value.ToString()),
                    Type = currentRow.Cells["type"].Value.ToString(),
                    Name = currentRow.Cells["name"].Value.ToString(),
                    Color = currentRow.Cells["color"].Value.ToString(),
                    Size = currentRow.Cells["size"].Value.ToString(),
                    Stock = int.Parse(currentRow.Cells["stock"].Value.ToString()),
                    Price = long.Parse(currentRow.Cells["price"].Value.ToString())
                };

                using (ProductDetailForm frm = new ProductDetailForm())
                {
                    frm.loadData(currentProduct);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        loadAllProduct();
                    }
                }
            }
        }

        private void grid_stock_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string colname = grid_stock.Columns[e.ColumnIndex].Name;
            if (colname != "btn_edit")
            {
                grid_stock.Cursor = Cursors.Default;
            }
            else
            {
                grid_stock.Cursor = Cursors.Hand;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validToAdd())
            {
                Product product = new Product
                {
                    Type = txt_type.Text,
                    Name = txt_name.Text,
                    Stock = int.Parse(txt_stock.Value.ToString()),
                    Size = txt_size.Text,
                    Color = txt_color.Text,
                    Price = long.Parse(txt_price.Value.ToString())
                };

                if (myDB.addProduct(product))
                {
                    MessageBox.Show("Sản phẩm đã được thêm!", "TỒN KHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshForm();
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string size;
            if (rbtn_size_s.Checked)
                size = Global.sizeS;
            else if (rbtn_size_m.Checked)
                size = Global.sizeM;
            else if (rbtn_size_l.Checked)
                size = Global.sizeL;
            else if (rbtn_size_xl.Checked)
                size = Global.sizeXL;
            else if (rbtn_size_xxl.Checked)
                size = Global.sizeXXL;
            else
                size = Global.sizeAll;
            filterData(size, txt_search.Text);
        }

        private void rbtn_size_s_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_size_s.Checked)
                filterData(Global.sizeS, txt_search.Text);
            else
                filterData(Global.sizeAll, txt_search.Text);
        }

        private void rbtn_size_m_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_size_m.Checked)
                filterData(Global.sizeM, txt_search.Text);
            else
                filterData(Global.sizeAll, txt_search.Text);
        }

        private void rbtn_size_l_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_size_l.Checked)
                filterData(Global.sizeL, txt_search.Text);
            else
                filterData(Global.sizeAll, txt_search.Text);
        }

        private void rbtn_size_xl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_size_xl.Checked)
                filterData(Global.sizeXL, txt_search.Text);
            else
                filterData(Global.sizeAll, txt_search.Text);
        }

        private void rbtn_size_xxl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_size_xxl.Checked)
                filterData(Global.sizeXL, txt_search.Text);
            else
                filterData(Global.sizeAll, txt_search.Text);
        }

        private void rbtn_size_all_CheckedChanged(object sender, EventArgs e)
        {
            filterData(Global.sizeAll, txt_search.Text);
        }

        #endregion Event Handlers
    }
}