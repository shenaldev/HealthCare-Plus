using System;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Common
{
    public partial class PaymentForm : Form
    {
        string selectedPaymentMethod = "cash";
        float total;

        public PaymentForm(float total)
        {
            InitializeComponent();
            this.total = total;

            //SET LABEL VALUES
            TotalAmount.Text = "RS: " + total.ToString();
            TotalAmountMid.Text = "RS: " + total.ToString();
            BalanceAmount.Text = "";
        }

        private void OnCashSelect(object sender, EventArgs e)
        {
            selectedPaymentMethod = "cash";
            ShowHideCashPanel(selectedPaymentMethod);
        }

        private void OnCardSelect(object sender, EventArgs e)
        {
            selectedPaymentMethod = "card";
            ShowHideCashPanel(selectedPaymentMethod);
        }

        private void OnCashAmountChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CashInput.Text))
            {
                float cashIn = float.Parse(CashInput.Text);
                BalanceAmount.Text = "RS: " + (cashIn - total).ToString();
            }
        }

        //SHOW HIDE PAYMENT INPUTS FOR CASH PANEL
        private void ShowHideCashPanel(string method)
        {
            if (method == "cash")
            {
                CashLabel.Visible = true;
                CashInput.Visible = true;
                TotalLableMid.Visible = true;
                TotalAmountMid.Visible = true;
                BalanceLabel.Visible = true;
                BalanceAmount.Visible = true;
            }
            else
            {
                CashLabel.Visible = false;
                CashInput.Visible = false;
                TotalLableMid.Visible = false;
                TotalAmountMid.Visible = false;
                BalanceLabel.Visible = false;
                BalanceAmount.Visible = false;
            }
        }
    }
}
