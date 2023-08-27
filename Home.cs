using HealthCare_Plus.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            staffLoginForm.ShowDialog();
        }
    }
}
