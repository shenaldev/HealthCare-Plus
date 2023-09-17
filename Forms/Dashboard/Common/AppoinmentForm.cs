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
        DBCon dbCon = new DBCon();
        DataGridView apptGridView;
        Int64 selectedAppt = 0;

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
            string selectQuery =
                "SELECT apt.id, Patients.first_name + ' ' + Patients.last_name AS Patient, "
                + "apt.appt_number AS Number, apt.payment_status, "
                + "sch.start_date, sch.location, "
                + "Users.first_name + ' ' + Users.last_name AS Doctor "
                + "FROM Appointments as apt "
                + "INNER JOIN Schedules AS sch ON apt.schedule_id = sch.id "
                + "INNER JOIN Users ON sch.doctor_id = Users.id "
                + "INNER JOIN Patients ON apt.patient_id = Patients.id";

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
                Console.WriteLine(ex.Message);
                MessageBox.Show("Server Error", "Error", default, MessageBoxIcon.Error);
            }
        }
    }
}
