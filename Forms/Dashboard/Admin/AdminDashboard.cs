using HealthCare_Plus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            AuthUser authUser = AuthUser.Instance;
            if(authUser == null)
            {
                MessageBox.Show("You are not loged in", "Unathorized", default, MessageBoxIcon.Error);
                return;
            }
            //SET USER NAME ON FORM
            username_label.Text = authUser.FirstName;
        }

        /**
         * HANDLE USER LOGOUT -> DELETE AUTHUSER OBJECT AND REDIRECT TO HOMEPAGE 
         */
        private void logout_btn_Click(object sender, EventArgs e)
        {
            AuthUser authUser = AuthUser.Instance;
            authUser = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            MessageBox.Show("Logged Out Successfull!", "Success", default, MessageBoxIcon.Information);
            Home homePage = new Home();
            this.Hide();
            homePage.Show();
        }
    }
}
