using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{
    internal class Appointment
    {
        private int appointmentNo;
        private string paymentStatus;
        private Int64 scheduelID;
        private Int64 patientID;

        //SQL QUERIES
        private string insertQuery =
            "INSERT INTO Appointments (appt_number, payment_status, schedule_id, patient_id, created_at) "
            + "output INSERTED.ID "
            + "VALUES (@appt_number, 'unpaid', @schedule_id, @patient_id, @created_at)";

        public int AppointmentNo
        {
            get { return appointmentNo; }
            set { appointmentNo = value; }
        }
        public string PaymentStatus
        {
            get { return paymentStatus; }
            set { paymentStatus = value; }
        }
        public Int64 ScheduelID
        {
            get { return scheduelID; }
            set { scheduelID = value; }
        }
        public Int64 PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public Appointment(int AppointmentNo, string paymentStatus, Int64 scheduleID, Int64 patientID)
        {
            this.AppointmentNo = AppointmentNo;
            this.PaymentStatus = paymentStatus;
            this.scheduelID = scheduleID;
            this.patientID = patientID;
        }

        public SqlCommand GetInsertCmd(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@appt_number", this.appointmentNo);
            command.Parameters.AddWithValue("@schedule_id", scheduelID);
            command.Parameters.AddWithValue("@patient_id", patientID);
            command.Parameters.AddWithValue("@created_at", DateTime.Now.ToString());
            return command;
        }
    }
}
