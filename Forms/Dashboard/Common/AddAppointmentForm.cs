using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Common
{
    public partial class AddAppointmentForm : Form
    {
        //VARIABLES
        DBCon dBCon = new DBCon();
        Int64 selectedDoctorID;
        Appointment appointment;
        DataTable ChargesDataTable = new DataTable();
        PaymentForm paymentForm;
        int ChargesID = 1;
        int deleteChargeID;

        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.selectDoctorDataSet.Users);
            this.patientsTableAdapter.Fill(this.healthcareplusDataSet.Patients);
            //LOAD DOCTOR BASED ON SELECTED ID
            selectedDoctorID = Int64.Parse(Select_Doc.SelectedValue.ToString());
            LoadSchedules(selectedDoctorID);

            //CREATE CHARGES DATATABLE
            ChargesDataTable.Columns.Add("id", typeof(Int64));
            ChargesDataTable.Columns.Add("title", typeof(string));
            ChargesDataTable.Columns.Add("amount", typeof(float));
            ChargesGridView.DataSource = ChargesDataTable;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //HANDLE DOCTOR CHANGE AND LOAD SCHEDULES
        private void OnDoctorChangeHandler(object sender, EventArgs e)
        {
            if (Select_Doc.SelectedValue != null)
            {
                selectedDoctorID = Int64.Parse(Select_Doc.SelectedValue.ToString());
            }
            LoadSchedules(selectedDoctorID);
        }

        //ON SCHEDULE CHANGE ASSIGN APPOINTMENT NUMBER
        private void OnScheduleChange(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Appointments WHERE schedule_id = @schedule_id";
            SqlConnection sqlCon = dBCon.SqlConnection;
            try
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                adapter.SelectCommand.Parameters.AddWithValue("@schedule_id", Select_Schedule.SelectedValue.ToString());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                sqlCon.Close();

                int count = Int32.Parse(dataTable.Rows[0][0].ToString());
                ApptNumberInput.Text = (count + 1).ToString();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
            }
        }

        /*LOAD SCHEDULES FROM DATABASE
         *@param Int64 doctor_id
         **/
        private void LoadSchedules(Int64 doctor_id)
        {
            string query =
                "SELECT Schedules.id, Users.first_name + ' ' + Users.last_name + ' Room ' + "
                + "CAST(Schedules.room AS varchar(10)) + ' ' + Schedules.location + ' ' + "
                + "CAST(Schedules.start_date AS varchar(20)) AS details "
                + "FROM Schedules "
                + "INNER JOIN Users ON Schedules.doctor_id = Users.id "
                + "WHERE Schedules.doctor_id = @doctor_id "
                + "ORDER BY Schedules.id DESC";

            try
            {
                SqlConnection sqlCon = dBCon.SqlConnection;
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                adapter.SelectCommand.Parameters.AddWithValue("@doctor_id", doctor_id);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                sqlCon.Close();

                Select_Schedule.DataSource = dataTable;
                Select_Schedule.DisplayMember = "details";
                Select_Schedule.ValueMember = "id";
                Select_Schedule.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Select_Schedule.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddChargeBtn_Click(object sender, EventArgs e)
        {
            string title = ChargeForInput.Text;
            string amount = AmountInput.Text;

            bool isInputValid = ValidateChargeInputs(title, amount);
            if (isInputValid)
            {
                ChargesDataTable.Rows.Add(ChargesID, title, amount);
                ChargesID++;
                ResetInputs();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ChargesDataTable.Select("id = " + deleteChargeID)[0].Delete();
            ChargesDataTable.AcceptChanges();
            deleteChargeID = 0;
            ResetInputs();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        //ADD APPOINTMENT TO DATABASE
        private void MakeApptBtn_Click(object sender, EventArgs e)
        {
            if (ChargesDataTable.Rows.Count < 1)
            {
                MessageBox.Show("Please add charges", "Validation Error", default, MessageBoxIcon.Error);
                return;
            }

            Int64 appointmentID = MakeAppointment();
            if (appointmentID == -2)
                return; // VALIDATION ERROR RETURN

            if (appointmentID != -1)
            {
                float total = 0;
                foreach (DataRow row in ChargesDataTable.Rows)
                {
                    total += float.Parse(row["amount"].ToString());
                }

                paymentForm = new PaymentForm(total, appointmentID);
                paymentForm.FormClosed += (s, args) => PaymentFormClosed(args);
                paymentForm.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong", "Error", default, MessageBoxIcon.Error);
            }
        }

        //ON CHARGE DOUBLE CLICK HANDLER
        private void OnCellDoubleClickHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            AddChargeBtn.Enabled = false;
            DeleteBtn.Enabled = true;

            deleteChargeID = Int32.Parse(ChargesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            ChargeForInput.Text = ChargesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            AmountInput.Text = ChargesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        /*MAKE APPOINTMENT TO DATABASE
         * @return int appointment id
         */
        private Int64 MakeAppointment()
        {
            //APPOINTMENT OBJECT
            int ApptNumber = string.IsNullOrEmpty(ApptNumberInput.Text) ? -1 : int.Parse(ApptNumberInput.Text);
            appointment = new Appointment(
                ApptNumber,
                "unpaid",
                Int64.Parse(Select_Schedule.SelectedValue.ToString()),
                Int64.Parse(Select_Patient.SelectedValue.ToString())
            );

            //VALIDATE FORM INPUTS
            bool isValid = ValidateApptInputs();
            if (!isValid)
            {
                return -2; //VALIDATION ERROR
            }

            string chargesQuery =
                "INSERT INTO Appointment_Charges (title, amount, appointment_id) "
                + "VALUES (@title, @amount, @appointment_id)";

            SqlConnection sqlCon = dBCon.SqlConnection;
            try
            {
                sqlCon.Open();
                SqlCommand cmd = appointment.GetInsertCmd(sqlCon);
                Int64 appointmentID = Convert.ToInt64(cmd.ExecuteScalar());

                foreach (DataRow row in ChargesDataTable.Rows)
                {
                    SqlCommand chargesCmd = new SqlCommand(chargesQuery, sqlCon);
                    chargesCmd.Parameters.AddWithValue("@title", row["title"].ToString());
                    chargesCmd.Parameters.AddWithValue("@amount", row["amount"].ToString());
                    chargesCmd.Parameters.AddWithValue("@appointment_id", appointmentID.ToString());
                    chargesCmd.ExecuteNonQuery();
                }

                sqlCon.Close();
                return appointmentID;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        //HIDE THIS FORM ON PAYMENT DONE
        private void PaymentFormClosed(FormClosedEventArgs args)
        {
            MessageBox.Show("Appointment Added Sccessfuly", "Success", default, MessageBoxIcon.Information);
            this.Hide();
        }

        private bool ValidateApptInputs()
        {
            List<string> errors = new List<string>
            {
                InputValidator.SelectionValidate(appointment.PatientID.ToString(), "Patient"),
                InputValidator.SelectionValidate(appointment.ScheduelID.ToString(), "Schedule"),
                InputValidator.NumberValidate(appointment.AppointmentNo.ToString(), "Appointment Number")
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

        /*VALIDATE CHARGE INPUTS
        * @param string title
        * @param string amount
        * @return bool
        */
        private bool ValidateChargeInputs(string title, string amount)
        {
            List<string> errors = new List<string>
            {
                InputValidator.SelectionValidate(title, "Charge For"),
                InputValidator.NumberValidate(amount, "Amount")
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

        //RESET INPUTS
        private void ResetInputs()
        {
            AddChargeBtn.Enabled = true;
            DeleteBtn.Enabled = false;
            ChargeForInput.Text = "";
            AmountInput.Text = "";
        }
    }
}
