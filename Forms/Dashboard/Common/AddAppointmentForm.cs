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
        DataTable ChargesDataTable = new DataTable();
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
            Select_Doc.Items.Clear();
            if (Select_Doc.SelectedValue != null)
            {
                selectedDoctorID = Int64.Parse(Select_Doc.SelectedValue.ToString());
            }
            LoadSchedules(selectedDoctorID);
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

            float total = 0;
            foreach (DataRow row in ChargesDataTable.Rows)
            {
                total += float.Parse(row["amount"].ToString());
            }

            PaymentForm paymentForm = new PaymentForm(total);
            paymentForm.Show();
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
