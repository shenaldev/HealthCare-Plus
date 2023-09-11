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

namespace HealthCare_Plus.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private User patient = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void back_to_home_lable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e) { }

        private void register_btn_Click(object sender, EventArgs e)
        {
            patient = new User(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                password_input.Text,
                address_input.Text,
                "staff"
            );
            Console.WriteLine("name is " + patient.FirstName);
        }
    }
}
