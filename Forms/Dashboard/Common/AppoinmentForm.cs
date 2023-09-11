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
    }
}
