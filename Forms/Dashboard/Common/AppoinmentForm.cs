using System;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Common
{
    public partial class AppoinmentForm : Form
    {
        public AppoinmentForm()
        {
            InitializeComponent();
        }

        private void AppoinmentForm_Load(object sender, EventArgs e)
        {
            this.patientsTableAdapter.Fill(this.healthcareplusDataSet.Patients);
            this.usersTableAdapter.Fill(this.selectDoctorDataSet.Users);
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

        private void View_invoice_btn_Click(object sender, EventArgs e) { }
    }
}
