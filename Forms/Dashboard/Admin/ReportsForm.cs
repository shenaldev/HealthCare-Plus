using HealthCare_Plus.Utils;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class ReportsForm : Form
    {
        private DBCon dBCon = new DBCon();
        private ReportViewer reportViewer;
        private string selectDocQuery =
            "SELECT * FROM Users "
            + "INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id "
            + "WHERE Role = 'doctor' ";

        public ReportsForm()
        {
            InitializeComponent();
            reportViewer = reportsView;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            //GENERATE DOCTORS REPORT ON FORM LOAD
            GenerateReport(
                selectDocQuery,
                "DoctorsDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.DoctorsReport.rdlc"
            );
        }

        private void DoctorsReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport(
                selectDocQuery,
                "DoctorsDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.DoctorsReport.rdlc"
            );
        }

        private void PatientsReportBtn_Click(object sender, EventArgs e)
        {
            string selectPatiQuery = "SELECT * FROM Patients";
            GenerateReport(
                selectPatiQuery,
                "PatientDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.PatientsReport.rdlc"
            );
        }

        private void PaymentsReportBtn_Click(object sender, EventArgs e)
        {
            string selectPaymentsQuery = "SELECT * FROM Payments";
            GenerateReport(
                selectPaymentsQuery,
                "PaymentsDataSet",
                "HealthCare_Plus.Forms.Dashboard.Reports.PaymentsReport.rdlc"
            );
        }

        private void GenerateReport(string query, string datSetName, string reportPath)
        {
            SqlConnection sqlCon = dBCon.SqlConnection;
            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlCon.Close();

                reportViewer.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource(datSetName, dataTable);
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportEmbeddedResource = reportViewer.LocalReport.ReportEmbeddedResource =
                    reportPath;
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
