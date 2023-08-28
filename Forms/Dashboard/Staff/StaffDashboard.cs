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
            label1.Text = authUser.Email;
        }
    }
}
