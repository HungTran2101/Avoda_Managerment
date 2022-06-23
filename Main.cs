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

namespace Avoda_Managerment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Button currentButton;
        private Form currentForm;

        private void Main_Load(object sender, EventArgs e)
        {
            Btn_cancel.Visible = false;
            BackColor = Global.mainColor;
            Pnl_nav.BackColor = Global.deactiveColor;
            btn_buy_form.BackColor = Global.deactiveColor;
            btn_customer_form.BackColor = Global.deactiveColor;
            btn_stock_form.BackColor = Global.deactiveColor;
            btn_transaction_form.BackColor = Global.deactiveColor;
        }

        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DeactiveButton();
                    Color backColor;
                    currentButton = (Button)sender;
                    switch (currentButton.Tag)
                    {
                        case "1": // buy/trade
                            backColor = Global.buyActiveColor;
                            break;

                        case "2": // customer
                            backColor = Global.customerActiveColor;
                            break;

                        case "3": // stock
                            backColor = Global.stockActiveColor;
                            break;

                        case "4": // transaction
                            backColor = Global.transactionColor;
                            break;

                        default:
                            backColor = Global.deactiveColor;
                            break;
                    }
                    currentButton.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    currentButton.BackColor = backColor;
                    Pnl_title.BackColor = backColor;
                    Btn_cancel.BackColor = backColor;
                    Pnl_logo.BackColor = backColor;
                    Pnl_nav.BackColor = backColor;
                }
            }
        }

        private void DeactiveButton()
        {
            foreach (Control control in Pnl_nav.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Font = new Font("Sitka Text", 17F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    control.BackColor = Global.deactiveColor;
                }
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (currentForm != null)
            {
                currentForm.Dispose();
            }
            ActiveButton(sender);

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.AutoScroll = true;
            childForm.Dock = DockStyle.Fill;

            Pnl_mainSection.Controls.Add(childForm);
            Pnl_mainSection.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            Lbl_title.Text = childForm.Text;
            Btn_cancel.Visible = true;
        }

        private void Btn_giaoDich_Click(object sender, EventArgs e)
        {
            if (currentButton != null && currentButton.Tag.ToString() == "1")
                return;
            OpenChildForm(new Forms.BuyTradeForm(), sender);
        }

        private void Btn_khachHang_Click(object sender, EventArgs e)
        {
            if (currentButton != null && currentButton.Tag.ToString() == "2")
                return;
            OpenChildForm(new Forms.CustomerForm(), sender);
        }

        private void Btn_tonKho_Click(object sender, EventArgs e)
        {
            if (currentButton != null && currentButton.Tag.ToString() == "3")
                return;
            OpenChildForm(new Forms.StockForm(), sender);
        }

        private void Btn_lichSu_Click(object sender, EventArgs e)
        {
            if (currentButton != null && currentButton.Tag.ToString() == "4")
                return;
            OpenChildForm(new Forms.TransactionForm(), sender);
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
                currentForm.Dispose();

            DeactiveButton();
            Pnl_title.BackColor = Global.titleWaitingColor;
            Pnl_logo.BackColor = Global.titleWaitingColor;
            Lbl_title.Text = "Trang chủ";
            currentButton = null;
            currentForm = null;
            Btn_cancel.Visible = false;
        }
    }
}