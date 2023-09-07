using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{

    internal class StaffMemeber: User
    {
        //VARIABLES
        private string insertQuery = "INSERT INTO StaffProfiles " +
                "(contact_no, address, user_id) " +
                "VALUES (@contact_no, @address, @user_id);";
        private string updateQuery = "UPDATE StaffProfiles SET "+
                    "contact_no = @contact_no, " +
                    "address = @address " +
                    "WHERE user_id = @user_id;";
        private string deleteQuery = "DELETE FROM StaffProfiles WHERE user_id = @user_id";

        public StaffMemeber()
        {
            //DEFAULT CONSTRUCTOR
        }

        public StaffMemeber(
            string first_name,
            string last_name,
            string email,
            string phone_no,
            string password,
            string address,
            string role): base(first_name, last_name, email, phone_no, password, address, role)
        {
           
        }

        public SqlCommand GetStaffInsertCommand(SqlConnection connection, Int64 user_id)
        {
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@contact_no", base.PhoneNumber);
            command.Parameters.AddWithValue("@address", base.Address);
            command.Parameters.AddWithValue("@user_id", user_id);
            return command;
        }

        public SqlCommand GetStaffUpdateCommand(SqlConnection connection, Int64 user_id)
        {
            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@contact_no", base.PhoneNumber);
            command.Parameters.AddWithValue("@address", base.Address);
            command.Parameters.AddWithValue("@user_id", user_id);
            return command;
        }

        public SqlCommand GetStaffDeleteCommand(SqlConnection connection, Int64 user_id)
        {
            SqlCommand command = new SqlCommand(deleteQuery,connection);
            command.Parameters.AddWithValue("@user_id", user_id);
            return command;
        }
    }
}
