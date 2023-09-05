using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class PatientsForm : Form
    {
        //VARIABLES
        private DataGridView patientsDataGrid;
        private DBCon dBCon = new DBCon();

        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            patientsDataGrid = PatientDataGridView; // INIT GRID VIEW
            LoadPatientData();
        }

        //GET PATIENTS DATA FROM DATABASE AND LOAD IT INTO DATA GRID
        private void LoadPatientData()
        {
            try
            {
                SqlConnection sqlConnection = dBCon.SqlConnection;
                sqlConnection.Open();
                string query = "SELECT * FROM Patients";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                patientsDataGrid.DataSource = dataTable;
                sqlConnection.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
