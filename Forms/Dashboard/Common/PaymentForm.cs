using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Common
{
    public partial class PaymentForm : Form
    {
        string selectedPaymentMethod = "cash";
        Payment payment;
        DBCon dbCon = new DBCon();
        float total;
        float balance;
        Int64 appointmentID;

        public PaymentForm(float total, Int64 appointmentID)
        {
            InitializeComponent();
            this.total = total;
            this.appointmentID = appointmentID;

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
            if (!string.IsNullOrEmpty(CashInput.Text))
            {
                float cashIn = float.Parse(CashInput.Text);
                balance = cashIn - total;
                BalanceAmount.Text = "RS: " + balance.ToString();
            }
        }

        private void MakePaymentBtn_Click(object sender, EventArgs e)
        {
            //PAYMENT OBJECT
            payment = new Payment(selectedPaymentMethod, total, balance, appointmentID);

            //VALIDTE FORM
            bool isValid = ValidateForm();
            if (!isValid)
            {
                return;
            }

            SqlConnection sqlCon = dbCon.SqlConnection;
            try
            {
                sqlCon.Open();
                SqlCommand cmd = payment.GetInsertCmd(sqlCon);
                cmd.ExecuteNonQuery();

                //MAKE AS PAID IN APPOINTMENT TABLE
                string updateApptQuery = "UPDATE Appointments SET payment_status = 'paid' WHERE id = @id";
                SqlCommand updateApptCmd = new SqlCommand(updateApptQuery, sqlCon);
                updateApptCmd.Parameters.AddWithValue("@id", appointmentID);
                updateApptCmd.ExecuteNonQuery();

                sqlCon.Close();
                MessageBox.Show("Payment Success", "Success", default, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
                MessageBox.Show("Something went wrong", "Error", default, MessageBoxIcon.Error);
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

        //VALIDATE FROM INPUT
        private bool ValidateForm()
        {
            if (selectedPaymentMethod == "cash")
            {
                if (string.IsNullOrEmpty(CashInput.Text))
                {
                    MessageBox.Show("Cash amount is required", "Error", default, MessageBoxIcon.Error);
                    return false;
                }
                bool cashAmount = int.TryParse(CashInput.Text, out int amount);
                if (cashAmount)
                {
                    if (amount < total)
                    {
                        MessageBox.Show("Insufficient amount", "Error", default, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
