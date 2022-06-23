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
    public partial class CustomerForm : Form
    {
        private Database myDB;
        private DataTable customersData;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;
            grid_customer.BackgroundColor = Global.mainColor;

            myDB = Database.getInstance();
            loadAllCustomer();
        }

        private void loadAllCustomer()
        {
            customersData = myDB.getAllCustomer();
            grid_customer.DataSource = customersData;
            resizeGridView();
        }

        private void resizeGridView()
        {
            int total_width = 0;
            foreach (DataGridViewColumn col in grid_customer.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                total_width += col.Width;
            }
            if (total_width < grid_customer.Width)
            {
                grid_customer.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        #region Event Handlers

        private void grid_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = senderGrid.Rows[e.RowIndex];

                Customer currentCustomer = new Customer
                {
                    Id = int.Parse(currentRow.Cells["id"].Value.ToString()),
                    Name = currentRow.Cells["name"].Value.ToString(),
                    Phone = currentRow.Cells["phone"].Value.ToString(),
                    Score = int.Parse(currentRow.Cells["score"].Value.ToString()),
                };

                using (CustomerDetailForm frm = new CustomerDetailForm())
                {
                    frm.loadData(currentCustomer);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        loadAllCustomer();

                        // continue show previous search result
                        string search = txt_search.Text;
                        txt_search.Clear();
                        txt_search.Text = search;
                    }
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text;

            DataView temp = new DataView(customersData)
            {
                RowFilter = "CONVERT(id, System.String) LIKE '%" + search + "%' OR " +
                    "name LIKE '%" + search + "%' OR " +
                    "phone LIKE '%" + search + "%'"
            };
            grid_customer.DataSource = temp;
            resizeGridView();
        }

        #endregion Event Handlers
    }
}