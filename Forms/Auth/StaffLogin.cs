using HealthCare_Plus.Forms.Dashboard;
using HealthCare_Plus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Auth
{
    public partial class StaffLoginForm : Form
    {
        private string EmailAddress = null;
        private string Password = null;

        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void back_to_home_lable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            EmailAddress = email_input.Text;
            Password = password_input.Text;

            // USER INPUT VALIDATON AND SHOW ERRORS
            string validation = FormValidate(EmailAddress, Password);
            if (validation != "valid")
            {
                MessageBox.Show(validation, "Error",default, MessageBoxIcon.Error);
            }

            if(validation == "valid")
            {
                var authUser = AuthUser.Instance;
                authUser.Email = EmailAddress;
                authUser.role = "staff";

                //SHOW STAFF DASHBOARD ON LOGIN SUCCESS
                Console.WriteLine("login");
                StaffDashboard staffDashboard = new StaffDashboard();
                this.Hide();
                staffDashboard.Show();
            }
        }

        //VALIDATE LOGIN FORM INPUTS
        private string FormValidate(string email, string password)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) {
                return "Email and password is required";
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            if(!regex.IsMatch(email))
            {
                return "Invalid email address";
            }

            return "valid";
        }
    }
}
