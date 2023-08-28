using HealthCare_Plus.Forms.Auth;
using System;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            StaffLoginForm staffLoginForm = new StaffLoginForm();
            this.Hide();
            staffLoginForm.Show();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            this.Hide();
            adminLoginForm.Show();
        }
    }
}
