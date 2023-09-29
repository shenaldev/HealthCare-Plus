using System;
using System.Data.SqlClient;

namespace HealthCare_Plus.Models
{
    internal class Schedule
    {
        //VARIBLES
        private Int64 doctorId;
        private string location;
        private int roomNo;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private DateTime timeNow = DateTime.Now;

        public Int64 DoctorId
        {
            get => doctorId;
            set => doctorId = value;
        }
        public string Location
        {
            get => location;
            set => location = value;
        }
        public int RoomNo
        {
            get => roomNo;
            set => roomNo = value;
        }
        public DateTime StartDateTime
        {
            get => startDateTime;
            set => startDateTime = value;
        }
        public DateTime EndDateTime
        {
            get => endDateTime;
            set => endDateTime = value;
        }

        //QUERY VARIABLES
        private string insertQuery =
            "INSERT INTO Schedules "
            + "(doctor_id, location, room, start_date, end_date) "
            + "VALUES (@doctor_id, @location, @room, @start_date, @end_date)";
        private string updateQuery =
            "UPDATE Schedules SET "
            + "doctor_id = @doctor_id,"
            + "location = @location, "
            + "room = @room, "
            + "start_date = @start_date, "
            + "end_date = @end_date "
            + "WHERE id = @id";
        private string deleteQuery = "DELETE FROM Schedules WHERE id = @id";

        public Schedule()
        {
            //DEFAULT CONSTRUCTOR
        }

        //CONSTRUCTOR
        public Schedule(Int64 doctorId, string location, int roomNo, DateTime startDate, DateTime endDate)
        {
            this.doctorId = doctorId;
            this.location = location;
            this.roomNo = roomNo;
            this.startDateTime = startDate;
            this.endDateTime = endDate;
        }

        //INSERT COMMAND
        public SqlCommand GetInsertCmd(SqlConnection connection)
        {
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection);
            sqlCommand.Parameters.AddWithValue("@doctor_id", doctorId);
            sqlCommand.Parameters.AddWithValue("@location", location);
            sqlCommand.Parameters.AddWithValue("@room", roomNo);
            sqlCommand.Parameters.AddWithValue("@start_date", startDateTime);
            sqlCommand.Parameters.AddWithValue("@end_date", endDateTime);
            return sqlCommand;
        }

        //UPDATE COMMAND
        public SqlCommand GetUpdateCmd(SqlConnection connection, Int64 id)
        {
            SqlCommand sqlCommand = new SqlCommand(updateQuery, connection);
            sqlCommand.Parameters.AddWithValue("@doctor_id", doctorId);
            sqlCommand.Parameters.AddWithValue("@location", location);
            sqlCommand.Parameters.AddWithValue("@room", roomNo);
            sqlCommand.Parameters.AddWithValue("@start_date", startDateTime);
            sqlCommand.Parameters.AddWithValue("@end_date", endDateTime);
            sqlCommand.Parameters.AddWithValue("@id", id);
            return sqlCommand;
        }

        //DELETE COMMAND
        public SqlCommand GetDeleteCmd(SqlConnection connection, Int64 id)
        {
            SqlCommand sqlCommand = new SqlCommand(deleteQuery, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            return sqlCommand;
        }
    }
}
