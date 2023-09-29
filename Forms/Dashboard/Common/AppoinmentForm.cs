using HealthCare_Plus.Forms.Dashboard.Reports;
using HealthCare_Plus.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Common
{
    public partial class AppoinmentForm : Form
    {
        private DBCon dbCon = new DBCon();
        private DataGridView apptGridView;
        private Int64 selectedAppt = 0;
        private string selectQuery =
            "SELECT apt.id, Patients.first_name + ' ' + Patients.last_name AS Patient, "
            + "apt.appt_number AS Number, apt.payment_status, "
            + "sch.start_date, sch.location, "
            + "Users.first_name + ' ' + Users.last_name AS Doctor "
            + "FROM Appointments as apt "
            + "INNER JOIN Schedules AS sch ON apt.schedule_id = sch.id "
            + "INNER JOIN Users ON sch.doctor_id = Users.id "
            + "INNER JOIN Patients ON apt.patient_id = Patients.id";

        public AppoinmentForm()
        {
            InitializeComponent();
        }

        private void AppoinmentForm_Load(object sender, EventArgs e)
        {
            this.patientsTableAdapter.Fill(this.healthcareplusDataSet.Patients);
            this.usersTableAdapter.Fill(this.selectDoctorDataSet.Users);

            apptGridView = AppointmentsGridView;
            LoadAppointments();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.TopLevel = false;
            addAppointmentForm.FormBorderStyle = FormBorderStyle.None;
            addAppointmentForm.Dock = DockStyle.Fill;
            Parent.Controls.Add(addAppointmentForm);
            addAppointmentForm.BringToFront();
            addAppointmentForm.Show();
        }

        private void Update_btn_Click(object sender, EventArgs e) { }

        private void View_invoice_btn_Click(object sender, EventArgs e)
        {
            InvoiceView invoiceView = new InvoiceView(selectedAppt.ToString());
            invoiceView.Show();
        }

        private void OnGridViewCellDubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            //GET SELECTED ROW
            DataGridViewRow row = apptGridView.Rows[e.RowIndex];
            selectedAppt = Int64.Parse(row.Cells[0].Value.ToString());
            selected_apt_no.Text = selectedAppt.ToString();

            View_invoice_btn.Enabled = true;
        }

        private void LoadAppointments()
        {
            SqlConnection sqlCon = dbCon.SqlConnection;
            try
            {
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(selectQuery, sqlCon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                apptGridView.DataSource = dataTable;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
                MessageBox.Show("Server Error", "Error", default, MessageBoxIcon.Error);
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string doctorID = Search_doc_input.SelectedValue.ToString();
            string patientID = Search_patient_input.SelectedValue.ToString();
            string date = Search_date_input.Value.ToString("yyyy-MM-dd");

            string query = selectQuery + "WHERE CONVERT(varchar(30),sch.start_date,126) LIKE @start_date";

            if (doctorID != "0")
                query += " AND Users.id = @doctor_id";
            if (patientID != "0")
                query += " AND Patients.id = @patient_id";

            SqlConnection sqlCon = dbCon.SqlConnection;
            try
            {
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
                sqlCommand.Parameters.AddWithValue("@start_date", "%" + date + "%");
                if (doctorID != "0")
                    sqlCommand.Parameters.AddWithValue("@doctor_id", doctorID);
                if (patientID != "0")
                    sqlCommand.Parameters.AddWithValue("@patient_id", patientID);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No Appointments Found", "Not Found", default, MessageBoxIcon.Asterisk);
                    sqlCon.Close();
                    return;
                }
                apptGridView.DataSource = dataTable;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
                MessageBox.Show("Server Error", "Error", default, MessageBoxIcon.Error);
            }
        }
    }
}
