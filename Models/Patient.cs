using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{
    internal class Patient
    {
        private string first_name;
        private string last_name;
        private string email;
        private string phone_no;
        private string address;
        private string disease;

        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNo { get => phone_no; set => phone_no = value; }
        public string Address { get => address; set => address = value; }
        public string Disease { get => disease; set => disease = value; }

        //QUERY VARIABLES
        private string insertQuery = "INSERT INTO Patients " +
                "(first_name, last_name, email, contact_no, address, disease) " +
                "VALUES (@first_name, @last_name, @email, @contact_no, @address, @disease)";
        private string updateQuery = "UPDATE Patients SET " +
                "first_name = @first_name, " +
                "last_name = @last_name, " +
                "email = @email, " +
                "contact_no = @contact_no, " +
                "address = @address, " +
                "disease = @disease " +
                "WHERE id = @patient_id";
        private string deleteQuery = "DELETE FROM Patients WHERE id = @patient_id";

        public Patient()
        {
            //DEFAULT CONSTRUCTOR
        }

        public Patient(string first_name, string last_name, string email, string phone_no, string address, string disease)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_no = phone_no;
            this.address = address;
            this.disease = disease;
        }

        public SqlCommand GetInsertCommand(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@first_name", first_name);
            command.Parameters.AddWithValue("@last_name", last_name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@contact_no", phone_no);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@disease", disease);
            return command;
        }

        public SqlCommand GetUpdateCommand(SqlConnection connection, Int64 patient_id)
        {
            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@first_name", first_name);
            command.Parameters.AddWithValue("@last_name", last_name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@contact_no", phone_no);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@disease", disease);
            command.Parameters.AddWithValue("@patient_id", patient_id);
            return command;
        }

        public SqlCommand GetDeleteCommand(SqlConnection connection, Int64 patient_id)
        {
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@patient_id", patient_id);
            return command;
        }
    }
}
