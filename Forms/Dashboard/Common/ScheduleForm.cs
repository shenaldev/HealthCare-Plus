using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Common
{
    public partial class ScheduleForm : Form
    {
        //VARIABLES
        private DataGridView scheduleGridView;
        private DBCon dBCon = new DBCon();
        private Schedule schedule;
        private bool isScheduleSelected = false;
        private Int64 selectedScheduleID;
        private Dictionary<string, string> searchValues = new Dictionary<string, string>();

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, System.EventArgs e)
        {
            //INIT FROM
            this.usersTableAdapter.Fill(this.selectDoctorDataSet.Users);
            scheduleGridView = ScheduleDataGridView;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
            LoadSchedules();

            //SET TODAYS DATE IN DATE TIME PICKER
            startDate_input.Value = DateTime.Now;
            startDate_input.MinDate = DateTime.Now;
            endDateInput.Value = DateTime.Now;
            endDateInput.MinDate = DateTime.Now;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            int seletedRoomID = RoomUtils.GetSelectedRoomID(room_number_input.Text);

            //SCHEDULE OBJECT
            schedule = new Schedule(
                Int64.Parse(doctor_input.SelectedValue.ToString()),
                location_input.Text,
                seletedRoomID,
                startDate_input.Value,
                endDateInput.Value
            );

            //FORM VALIDATE
            bool isValidated = Validation();
            if (isValidated)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Schedule Added Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadSchedules();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            int seletedRoomID = RoomUtils.GetSelectedRoomID(room_number_input.Text);

            //SCHEDULE OBJECT
            schedule = new Schedule(
                Int64.Parse(doctor_input.SelectedValue.ToString()),
                location_input.Text,
                seletedRoomID,
                startDate_input.Value,
                endDateInput.Value
            );

            //FORM VALIDATE
            bool isValidated = Validation();
            if (isValidated)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedScheduleID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Schedule Updated Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadSchedules();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (isScheduleSelected)
            {
                var confirmation = MessageBox.Show(
                    "Are You Sure You Want To Delete This Schedule?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmation == DialogResult.Yes)
                {
                    bool sqlQueryStatus = DeleteQuery(selectedScheduleID);
                    if (sqlQueryStatus)
                    {
                        MessageBox.Show(
                            "Schedule Deleted Successfully",
                            "Success",
                            default,
                            MessageBoxIcon.Information
                        );
                        LoadSchedules(); // REFRESH DATA GRID VIEW
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ResetForm();
            selectedScheduleID = 0;
            isScheduleSelected = false;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SetSearchValues();

            //VALIDATE SEARCH VALUES
            string[] activeSearchValues = searchValues.Values.Where(val => val != "").ToArray();
            if (activeSearchValues.Length == 0)
            {
                MessageBox.Show(
                    "Please Enter At Least One Search Value",
                    "Validation Error",
                    default,
                    MessageBoxIcon.Error
                );
                return;
            }

            //BUILD QUERY BASED ON INPUTS
            string baseQuery =
                "SELECT Schedules.id, Users.first_name + ' ' + Users.last_name as doctor,Schedules.location, Schedules.room, Schedules.start_date, Schedules.end_date "
                + "FROM Schedules LEFT JOIN Users ON Users.id = Schedules.doctor_id ";

            if (searchValues.ContainsKey("date") && !string.IsNullOrEmpty(searchValues["date"]))
            {
                baseQuery += "WHERE CONVERT(varchar(30),Schedules.start_date,126) LIKE @date ";
            }
            if (searchValues.ContainsKey("doctor") && !string.IsNullOrEmpty(searchValues["doctor"]))
            {
                baseQuery += "AND Users.first_name + ' ' + Users.last_name LIKE @doctor ";
            }
            if (searchValues.ContainsKey("location") && !string.IsNullOrEmpty(searchValues["location"]))
            {
                baseQuery += "AND Schedules.location LIKE @location ";
            }

            SqlConnection sqlCon = dBCon.SqlConnection;
            try
            {
                sqlCon.Open();

                //EXECUTE SEARCH COMMAND AND FILL DATA TABLE
                SqlDataAdapter adapter = new SqlDataAdapter(baseQuery, sqlCon);

                if (searchValues.ContainsKey("date"))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@date", "%" + searchValues["date"] + "%");
                }
                if (searchValues.ContainsKey("doctor"))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@doctor", "%" + searchValues["doctor"] + "%");
                }
                if (searchValues.ContainsKey("location"))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@location", "%" + searchValues["location"] + "%");
                }

                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();

                //CHECK IF NO RECOARD FOUND
                if (dataTabel.Rows.Count == 0)
                {
                    MessageBox.Show("No schedule found", "No Results", default, MessageBoxIcon.Information);
                    return;
                }

                scheduleGridView.DataSource = dataTabel;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
            }
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return; // RETURN IF HEADER CLICKED

            Add_btn.Enabled = false;
            Update_btn.Enabled = true;
            Delete_btn.Enabled = true;

            //GET SELECTED ROW
            DataGridViewRow row = scheduleGridView.Rows[e.RowIndex];
            selectedScheduleID = Int64.Parse(row.Cells[0].Value.ToString());
            isScheduleSelected = true;

            //SET FORM DATA
            string doctorFullName = row.Cells[1].Value.ToString();
            string doctorName = doctorFullName.Split(' ')[0];
            doctor_input.Text = doctorName;
            location_input.Text = row.Cells[2].Value.ToString();
            int selectedRoomID = Int32.Parse(row.Cells[3].Value.ToString());
            room_number_input.Text = RoomUtils.GetSelectedRoomText(selectedRoomID);
            startDate_input.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            endDateInput.Value = DateTime.Parse(row.Cells[5].Value.ToString());
        }

        //LOAD SCHEDULES INTO DATA GRID VIEW
        private void LoadSchedules()
        {
            SqlConnection sqlConnection = dBCon.SqlConnection;
            try
            {
                sqlConnection.Open();
                string query =
                    "SELECT Schedules.id, Users.first_name + ' ' + Users.last_name as doctor,Schedules.location, Schedules.room, Schedules.start_date, Schedules.end_date "
                    + "FROM Schedules LEFT JOIN Users ON Users.id = Schedules.doctor_id "
                    + "ORDER BY Schedules.id DESC;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                scheduleGridView.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                Console.WriteLine(ex.Message);
            }
        }

        //INSERT AND UPDATE QUERIES
        private bool DBQuery(string operation, Int64 updateID = 0)
        {
            string operationType = operation == "INSERT" ? "INSERT" : "UPDATE";
            SqlConnection sqlCon = dBCon.SqlConnection;
            try
            {
                sqlCon.Open();

                if (operationType == "INSERT")
                {
                    SqlCommand insertCmd = schedule.GetInsertCmd(sqlCon);
                    insertCmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand updateCmd = schedule.GetUpdateCmd(sqlCon, updateID);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, operationType + " Error", default, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlCon.Close();
            }
            return true;
        }

        //DELETE QUERY
        private bool DeleteQuery(Int64 id)
        {
            SqlConnection sqlConnection = dBCon.SqlConnection;
            try
            {
                sqlConnection.Open();
                Schedule schedule = new Schedule();
                SqlCommand sqlCommand = schedule.GetDeleteCmd(sqlConnection, id);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        //FORM VALIDATION
        private bool Validation()
        {
            List<string> errors = new List<string>
            {
                InputValidator.SelectionValidate(schedule.DoctorId.ToString(), "Doctor"),
                InputValidator.SelectionValidate(schedule.Location, "Location"),
                InputValidator.SelectionValidate(schedule.RoomNo.ToString(), "Room No", true),
                InputValidator.DateValidate(schedule.StartDateTime, "Start Date", "future"),
                InputValidator.DateValidate(schedule.EndDateTime, "End Date", "future")
            };

            //ACTIVE ERRORS INTO ARRAY
            string[] activeErrors = errors.FindAll(err => err != "valid").ToArray();

            if (activeErrors.Length == 0)
            {
                return true;
            }
            //SHOW ERRORS
            MessageBox.Show(string.Join("\n", activeErrors), "Validation Error", default, MessageBoxIcon.Error);

            return false;
        }

        //FORM RESET
        private void ResetForm()
        {
            doctor_input.SelectedIndex = 0;
            location_input.Text = null;
            room_number_input.Text = null;
            startDate_input.Value = DateTime.Now;
            endDateInput.Value = DateTime.Now;
            Add_btn.Enabled = true;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
            //REFECH DATA ON RESET
            LoadSchedules();
        }

        //SET SEARCH VALUES
        private void SetSearchValues()
        {
            searchValues.Clear();
            searchValues.Add("doctor", searchDocInput.Text);
            searchValues.Add("location", searchLocationInput.Text);
            searchValues.Add("date", searchDateInput.Value.ToString("yyyy-MM-dd"));
        }
    }
}
