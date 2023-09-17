using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{
    internal class Payment
    {
        private string paymentMethod;
        private float total;
        private float balance = 0;
        private string status = "pending";
        private string transactionID = "null";
        private Int64 appointmentID;
        private DateTime createdAt;

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        public Int64 AppointmentID
        {
            get { return appointmentID; }
            set { appointmentID = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        //QUERY STRINGS
        private string insertQuery =
            "INSERT INTO Payments (payment_method, total, balance, status, transaction_id, appointment_id, created_at) "
            + "VALUES (@payment_method, @total, @balance, @status, @transaction_id, @appointment_id, @created_at)";

        //DEFAULT CONSTRUCTOR
        public Payment(string paymentMethod, float total, float balance, Int64 appointmentID)
        {
            this.paymentMethod = paymentMethod;
            this.total = total;
            this.balance = balance;
            this.appointmentID = appointmentID;
            createdAt = DateTime.Now;
        }

        //CONSTRUCTOR FOR CARD PAYMENT ONLINE
        public Payment(string paymentMethod, float total, string transactionID, Int64 appointmentID)
        {
            this.paymentMethod = paymentMethod;
            this.total = total;
            this.transactionID = transactionID;
            this.appointmentID = appointmentID;
            createdAt = DateTime.Now;
        }

        public SqlCommand GetInsertCmd(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@transaction_id", transactionID);
            cmd.Parameters.AddWithValue("@appointment_id", appointmentID);
            cmd.Parameters.AddWithValue("@created_at", createdAt);
            return cmd;
        }
    }
}
