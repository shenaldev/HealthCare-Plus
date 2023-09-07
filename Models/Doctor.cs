using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{
    internal class Doctor : User
    {
        private string hospital_address;
        private string specialization;
        private string qualification;
        private string location;

        public string HospitalAddress { get => hospital_address; set => hospital_address = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Location { get => location; set => location = value; }

        //QUERY STRINGS
        private string insertDocQuery = "INSERT INTO DoctorProfiles " +
                "(qualification, specialization, contact_no, location, home_address, hospital_address, user_id) " +
                "VALUES (@qualification, @specialization, @contact_no, @location, @home_address, @hospital_address, @user_id)";
        private string updateDocQuery = "UPDATE DoctorProfiles SET " +
                    "qualification = @qualification, " +
                    "specialization = @specialization, " +
                    "contact_no = @contact_no, " +
                    "location = @location, " +
                    "home_address = @home_address, " +
                    "hospital_address = @hospital_address " +
                    "WHERE user_id = @user_id";
        private string deleteDocQuery = "DELETE FROM DoctorProfiles WHERE user_id = @user_id";

        public Doctor()
        {
            //DEFAULT CONSTRUCTOR
        }

        public Doctor(string first_name,
            string last_name,
            string email,
            string phone_no, 
            string password,
            string address,
            string role, 
            string hospital_address,string specialization, string qualification, string location)
            : base(first_name, last_name, email, phone_no, password, address, role)
        {
            this.hospital_address = hospital_address;
            this.specialization = specialization;
            this.qualification = qualification;
            this.location = location;
        }

        public SqlCommand GetDocInsertCmd(SqlConnection connection,Int64 userID)
        {
            SqlCommand sqlCommand = new SqlCommand(insertDocQuery, connection);
            sqlCommand.Parameters.AddWithValue("@qualification", qualification);
            sqlCommand.Parameters.AddWithValue("@specialization", specialization);
            sqlCommand.Parameters.AddWithValue("@contact_no", base.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@location", location);
            sqlCommand.Parameters.AddWithValue("@home_address", base.Address);
            sqlCommand.Parameters.AddWithValue("@hospital_address", hospital_address);
            sqlCommand.Parameters.AddWithValue("@user_id", userID);
            return sqlCommand;
        }

        public SqlCommand GetDocUpdateCmd(SqlConnection connection, Int64 userID)
        {
            SqlCommand sqlCommand = new SqlCommand(updateDocQuery, connection);
            sqlCommand.Parameters.AddWithValue("@qualification", qualification);
            sqlCommand.Parameters.AddWithValue("@specialization", specialization);
            sqlCommand.Parameters.AddWithValue("@contact_no", base.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@location", location);
            sqlCommand.Parameters.AddWithValue("@home_address", base.Address);
            sqlCommand.Parameters.AddWithValue("@hospital_address", hospital_address);
            sqlCommand.Parameters.AddWithValue("@user_id", userID);
            return sqlCommand;
        }

        public SqlCommand GetDocDeleteCmd(SqlConnection connection, Int64 userID)
        {
            SqlCommand sqlCommand = new SqlCommand(deleteDocQuery, connection);
            sqlCommand.Parameters.AddWithValue("@user_id", userID);
            return sqlCommand;
        }

    }
}
