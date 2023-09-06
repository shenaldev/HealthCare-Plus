using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class PatientsForm : Form
    {
        //VARIABLES
        private DataGridView patientsDataGrid;
        private DBCon dBCon = new DBCon();
        private Patient patient;
        private bool isPatientSelected = false;
        private Int64 selectedPatientID;

        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            //DISABLE BUTTONS
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
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

        //DATA GRID VIEW CELL CLICK HANDLER
        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // RETURN IF HEADER CLICKED

            isPatientSelected = true;
            Update_btn.Enabled = true;
            Delete_btn.Enabled = true;

            DataGridViewRow selectedRow = PatientDataGridView.Rows[e.RowIndex];
            selectedPatientID = Int64.Parse(selectedRow.Cells[0].Value.ToString());
            First_name_input.Text = selectedRow.Cells[1].Value.ToString();
            Last_name_input.Text = selectedRow.Cells[2].Value.ToString();
            Email_input.Text = selectedRow.Cells[3].Value.ToString();
            Phone_no_input.Text = selectedRow.Cells[4].Value.ToString();
            Address_input.Text = selectedRow.Cells[5].Value.ToString();
            Disease_input.Text = selectedRow.Cells[6].Value.ToString();

            Add_btn.Enabled = false;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //PATIENT OBJECT
            patient = new Patient(First_name_input.Text,Last_name_input.Text,Email_input.Text,Phone_no_input.Text,Address_input.Text,Disease_input.Text);

            //VALIDATE PATIENT DATA
            bool isValid = Validation();
            if (isValid)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Patient Added Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadPatientData(); // REFRESH DATA GRID VIEW
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            //PATIENT OBJECT
            patient = new Patient(First_name_input.Text, Last_name_input.Text, Email_input.Text, Phone_no_input.Text, Address_input.Text, Disease_input.Text);

            //VALIDATE PATIENT DATA
            bool isValid = Validation();
            if (isValid)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedPatientID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Patient UPDATED Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadPatientData(); // REFRESH DATA GRID VIEW
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (isPatientSelected)
            {
                var confirmation = MessageBox.Show("Are You Sure You Want To Delete This Patient?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    bool sqlQueryStatus = DeleteQuery(selectedPatientID);
                    if (sqlQueryStatus)
                    {
                        MessageBox.Show("Patient Deleted Successfully", "Success", default, MessageBoxIcon.Information);
                        LoadPatientData(); // REFRESH DATA GRID VIEW
                        isPatientSelected = false;
                        selectedPatientID = 0;
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        //INSERT AND UPDATE QUERY
        private bool DBQuery(string operation,Int64 updateID = 0)
        {
            string operationType = operation == "INSERT" ? "INSERT" : "UPDATE";

            //INSERT QUERY
            string insertQuery = "INSERT INTO Patients " +
                "(first_name, last_name, email, contact_no, address, disease) " +
                "VALUES (@first_name, @last_name, @email, @contact_no, @address, @disease)";
            
            //UPDATE QUERY
            string updateQuery = "UPDATE Patients SET " +
                "first_name = @first_name, " +
                "last_name = @last_name, " +
                "email = @email, " +
                "contact_no = @contact_no, " +
                "address = @address, " +
                "disease = @disease " +
                "WHERE id = @id";

            try
            {
                SqlConnection sqlConnection = dBCon.SqlConnection;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(operationType == "INSERT" ? insertQuery : updateQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@first_name", patient.FirstName);
                sqlCommand.Parameters.AddWithValue("@last_name", patient.LastName);
                sqlCommand.Parameters.AddWithValue("@email", patient.Email);
                sqlCommand.Parameters.AddWithValue("@contact_no", patient.PhoneNo);
                sqlCommand.Parameters.AddWithValue("@address", patient.Address);
                sqlCommand.Parameters.AddWithValue("@disease", patient.Disease);
                if(operationType == "UPDATE")
                {
                    sqlCommand.Parameters.AddWithValue("@id", updateID);
                }
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                // SHOW ERROR OF DUPLICATE EMAIL
                if (ex.Message.Contains("Unique_Email"))
                {
                    MessageBox.Show("Email Already Exists", "Validation Error", default, MessageBoxIcon.Error);
                }
                return false;
            }

            return true;
        }

        //DELETE QUERY
        private bool DeleteQuery(Int64 deleteID)
        {
            string deleteQuery = "DELETE FROM Patients WHERE id = @id";
            try
            {
                SqlConnection sqlConnection = dBCon.SqlConnection;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", deleteID);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        //FORM VALIDATION
        private bool Validation(string operation = "INSERT")
        {
            List<string> errors = new List<string>
            {
                InputValidator.TextValidate(patient.FirstName, "First Name"),
                InputValidator.TextValidate(patient.LastName, "Last Name"),
                InputValidator.EmailValidate(patient.Email),
                InputValidator.PhoneValidation(patient.PhoneNo),
                InputValidator.TextValidate(patient.Address, "Home Address"),
                InputValidator.TextValidate(patient.Disease, "Disease")
            };

            //ACTIVE ERRORS INTO ARRAY
            string[] activeErrors = errors.FindAll(err => err != "valid").ToArray();

            if (activeErrors.Length == 0)
            {
                return true;
            }
            //SHOW ERRORS
            MessageBox.Show(string.Join("\n", activeErrors), "Validation Error", default, MessageBoxIcon.Error);

            return false;
        }

        //RESET INPUT FIELDS
        private void ResetInputs()
        {
            First_name_input.Text = "";
            Last_name_input.Text = "";
            Email_input.Text = "";
            Phone_no_input.Text = "";
            Address_input.Text = "";
            Disease_input.Text = "";
            Add_btn.Enabled = true;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
        }

       
    }
}
