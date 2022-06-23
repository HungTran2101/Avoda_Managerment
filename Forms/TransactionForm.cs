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
    public partial class TransactionForm : Form
    {
        private Database myDB;
        private DataTable transactionData;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;
            grid_transaction.BackgroundColor = Global.mainColor;

            myDB = Database.getInstance();
            loadAllTransaction();
        }

        private void loadAllTransaction()
        {
            transactionData = myDB.getAllTransaction();
            grid_transaction.DataSource = transactionData;
            resizeGridView();
        }

        private void resizeGridView()
        {
            int total_width = 0;
            foreach (DataGridViewColumn col in grid_transaction.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                total_width += col.Width;
            }
            if (total_width < grid_transaction.Width)
            {
                grid_transaction.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void grid_transaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in grid_transaction.SelectedRows) //only one row selected
            {
                Transaction transaction = new Transaction
                {
                    Id = int.Parse(row.Cells["id"].Value.ToString()),
                    Name = row.Cells["name"].Value.ToString(),
                    Phone = row.Cells["phone"].Value.ToString(),
                    Total_price = long.Parse(row.Cells["total_price"].Value.ToString()),
                    Score_use = int.Parse(row.Cells["score_use"].Value.ToString()),
                    Final_price = long.Parse(row.Cells["final_price"].Value.ToString()),
                    Score_earn = int.Parse(row.Cells["score_earn"].Value.ToString()),
                    Date = DateTime.Parse(row.Cells["date"].Value.ToString())
                };

                using (TransactionDetailForm frm = new TransactionDetailForm())
                {
                    frm.loadData(transaction);
                    frm.ShowDialog(this);
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            DataView temp = new DataView(transactionData)
            {
                RowFilter = "CONVERT(id, System.String) LIKE '%" + search + "%' OR " +
                "name LIKE '%" + search + "%' OR " +
                "phone LIKE '%" + search + "%'"
            };
            grid_transaction.DataSource = temp;
            resizeGridView();
        }
    }
}