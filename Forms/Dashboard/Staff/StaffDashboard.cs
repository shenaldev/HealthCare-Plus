using HealthCare_Plus.Forms.Dashboard.Staff;
using HealthCare_Plus.Forms.Dashboard.Admin;
using HealthCare_Plus.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using HealthCare_Plus.Forms.Dashboard.Common;

namespace HealthCare_Plus.Forms.Dashboard
{
    public partial class StaffDashboard : Form
    {
        //VARIABLES
        private AuthUser authUser = AuthUser.Instance;
        private Button currentButton;
        private Form activeForm;

        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            //CHECK FOR AUTHORIZATION
            if (authUser == null)
            {
                MessageBox.Show("You are not loged in", "Unathorized", default, MessageBoxIcon.Error);
                return;
            }
            //SET USER NAME ON FORM
            username_label.Text = authUser.FirstName;
            OpenChildForm(new DoctorForm(), doctorsBtn);
        }

        /**
         * HANDLE USER LOGOUT -> DELETE AUTHUSER OBJECT AND REDIRECT TO HOMEPAGE
         */
        private void logout_btn_Click(object sender, EventArgs e)
        {
            authUser.Logout();
            Home homePage = new Home();
            this.Hide();
            homePage.Show();
        }

        /**
         * NAVIGATOIN BUTTON CLICK HANDLERS
         **/
        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorForm(), sender);
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientsForm(), sender);
        }

        private void SchedulesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleForm(), sender);
        }

        private void appoinmentsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AppoinmentForm(), sender);
        }

        private void reportsBtn_Click(object sender, EventArgs e) { }

        private void invoiceBtn_Click(object sender, EventArgs e) { }

        //CHANGE COLOR OF ACTIVE BUTTON
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtons();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(255, 122, 79);
                }
            }
        }

        //DIASABLE NAV BUTTON COLORS
        private void DisableButtons()
        {
            foreach (Control btn in navigationPanel.Controls)
            {
                if (btn.Name != "logout_btn")
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        btn.BackColor = Color.FromArgb(2, 36, 77);
                    }
                }
            }
        }

        //OPEN FORM RELATED TO BUTTON NAV
        private void OpenChildForm(Form form, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.bodyPanel.Controls.Add(form);
            this.bodyPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
