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
    public partial class TransactionDetailForm : Form
    {
        private Database myDB;
        private Transaction currentTransaction;

        public TransactionDetailForm()
        {
            InitializeComponent();
        }

        private void TransactionDetailForm_Load(object sender, EventArgs e)
        {
            BackColor = Global.mainColor;

            myDB = Database.getInstance();
            loadDetailTransaction();
        }

        public void loadData(Transaction transaction)
        {
            currentTransaction = transaction;
            txt_name.Text = transaction.Name;
            txt_phone.Text = transaction.Phone;
            txt_total_price.Text = Global.currencyToText(transaction.Total_price);
            txt_score_use.Text = transaction.Score_use.ToString();
            txt_final_price.Text = Global.currencyToText(transaction.Final_price);
            txt_score_earn.Text = transaction.Score_earn.ToString();
            txt_date.Text = transaction.Date.ToString();
        }

        private void loadDetailTransaction()
        {
            DataTable table = myDB.getDetailTransaction(currentTransaction.Id);
            grid_detail_transaction.DataSource = table;
        }
    }
}