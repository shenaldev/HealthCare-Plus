using HealthCare_Plus.Models;
using System;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard
{
    public partial class StaffDashboard : Form
    {
        private AuthUser authUser;
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            authUser = AuthUser.Instance;
            username_label.Text = authUser.FirstName;
        }
    }
}
