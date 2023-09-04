using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class DoctorsForm : Form
    {
        //VARIABLES
        Doctor doctor;
        Int64 selectedUserID;

        public DoctorsForm()
        {
            InitializeComponent();
        }

        //ONLOAD FUNCTION
        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadDoctorDataFromDB();
        }

        //LOAD DOCTOR DATA INTO DATAGRIDVIEW
        private void LoadDoctorDataFromDB()
        {
            try
            {
                DBCon dBCon = new DBCon();
                SqlConnection sqlCon = dBCon.SqlConnection;
                string query = "SELECT Users.id, Users.first_name, Users.last_name, Users.email, DoctorProfiles.qualification, DoctorProfiles.experties, DoctorProfiles.contact_no, DoctorProfiles.location, DoctorProfiles.home_address,DoctorProfiles.hospital_address FROM Users INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();
                doctorsDataGridView.DataSource = dataTabel;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        //DATA GRID VIEW CELL DOUBLE CLICK
        private void onCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = doctorsDataGridView.Rows[e.RowIndex];
            selectedUserID = Int64.Parse(selectedRow.Cells[0].Value.ToString());
            first_name_input.Text = selectedRow.Cells[1].Value.ToString();
            last_name_input.Text = selectedRow.Cells[2].Value.ToString();
            email_input.Text = selectedRow.Cells[3].Value.ToString();
            qualification_input.Text = selectedRow.Cells[4].Value.ToString();
            expertise_input.Text = selectedRow.Cells[5].Value.ToString();
            phone_no_input.Text = selectedRow.Cells[6].Value.ToString();
            location_input.Text = selectedRow.Cells[7].Value.ToString();
            home_address_input.Text = selectedRow.Cells[8].Value.ToString();
            hospital_address_input.Text = selectedRow.Cells[9].Value.ToString();
            password_input.Enabled = false; //DISABLE PASSWORD INPUT
            add_doc_btn.Enabled = false; //DISABLE ADD DOCTOR BUTTON
        }

        //HANDLE ADD DOCTOR BUTTON CLICK
        private void add_doc_btn_Click(object sender, EventArgs e)
        {
            //DOCTOR OBJECT
            doctor = new Doctor(first_name_input.Text, last_name_input.Text, email_input.Text, phone_no_input.Text, password_input.Text, home_address_input.Text, "doctor", hospital_address_input.Text, expertise_input.Text, qualification_input.Text, location_input.Text);

            bool isValidationPassed = Validation();
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Doctor Added Successfully", "Success", default,MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        //UPDATE BUTTON CLICK HANDLER
        private void update_doc_btn_Click(object sender, EventArgs e)
        {
            //DOCTOR OBJECT WITHOUT PASSWORD
            doctor = new Doctor(first_name_input.Text, last_name_input.Text, email_input.Text, phone_no_input.Text, "none", home_address_input.Text, "doctor", hospital_address_input.Text, expertise_input.Text, qualification_input.Text, location_input.Text);

            bool isValidationPassed = Validation("UPDATE");
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedUserID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Doctor Update Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        //INSERT AND UPDATE QUERY
        private bool DBQuery(string operation, Int64 updateID = 0)
        {
            string operationType = operation == "INSERT" ? "INSERT" : "UPDATE";
            SqlConnection sqlCon = null;
            SqlTransaction sqlTransaction = null;

            //QUERIES
            string query = "INSERT INTO Users " +
                "(first_name, last_name, email, password, role) " +
                "output INSERTED.ID " +
                "VALUES (@first_name, @last_name, @email, @password, @role)";

            string query2 = "INSERT INTO DoctorProfiles " +
                "(qualification, experties, contact_no, location, home_address, hospital_address, user_id) " +
                "VALUES (@qualification, @experties, @contact_no, @location, @home_address, @hospital_address, @user_id)";

            //UPDATE QUERY FOR OPERTION UPDATE
            if(operationType == "UPDATE")
            {
                query = "UPDATE Users SET " +
                    "first_name = @first_name, " +
                    "last_name = @last_name, " +
                    "email = @email " +
                    "WHERE id = @userID";

                query2 = "UPDATE DoctorProfiles SET " +
                    "qualification = @qualification, " +
                    "experties = @experties, " +
                    "contact_no = @contact_no, " +
                    "location = @location, " +
                    "home_address = @home_address, " +
                    "hospital_address = @hospital_address " +
                    "WHERE user_id = @userID";
            }

            try
            {
                DBCon dBCon = new DBCon();
                sqlCon = dBCon.SqlConnection;
                sqlCon.Open();
                sqlTransaction = sqlCon.BeginTransaction(); // TRANSACTION START

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Transaction = sqlTransaction;
                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                cmd2.Transaction = sqlTransaction;

                //QUERY 1 VALUES
                Hash passwordHash = new Hash();
                string hashedPassword = passwordHash.HashPassword(doctor.Password); //HASHED PASSWORD
                cmd.Parameters.AddWithValue("@first_name", doctor.FirstName);
                cmd.Parameters.AddWithValue("@last_name", doctor.LastName);
                cmd.Parameters.AddWithValue("@email", doctor.Email);
                if (operationType == "INSERT")
                {
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@role", doctor.Role);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@userID", updateID); //UPDATE USER ID
                }
                Int64 userID = Convert.ToInt64(cmd.ExecuteScalar());

                //QUERY 2 VALUES
                cmd2.Parameters.AddWithValue("@qualification", doctor.Qualification);
                cmd2.Parameters.AddWithValue("@experties", doctor.Experties);
                cmd2.Parameters.AddWithValue("@contact_no", doctor.PhoneNumber);
                cmd2.Parameters.AddWithValue("@location", doctor.Location);
                cmd2.Parameters.AddWithValue("@home_address", doctor.Address);
                cmd2.Parameters.AddWithValue("@hospital_address", doctor.HospitalAddress);
                if (operationType == "INSERT") 
                {
                    cmd2.Parameters.AddWithValue("@user_id", userID);
                }
                else
                {
                    cmd2.Parameters.AddWithValue("@userID", updateID); //UPDATE USER ID
                }
                cmd2.ExecuteNonQuery();
                sqlTransaction.Commit(); //COMMIT
            }
            catch (Exception ex)
            {
                //ROLLBACK TRANSACTION
                if(sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }

                Console.WriteLine(ex.Message);
                // SHOW ERROR OF DUPLICATE EMAIL
                if (ex.Message.Contains("Unique_Email"))
                {
                    MessageBox.Show("Email Already Exists", "Validation Error", default, MessageBoxIcon.Error);
                }
                return false;
            }
            finally
            {
                //CLOSE SQL CONNECTION
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            
            return true;
        }

        //FORM VALIDATION
        private bool Validation(string operation = "INSERT")
        {
            List<string> errors = new List<string>
            {
                InputValidator.TextValidate(doctor.FirstName, "First Name"),
                InputValidator.TextValidate(doctor.LastName, "Last Name"),
                InputValidator.EmailValidate(doctor.Email),
                InputValidator.PhoneValidation(doctor.PhoneNumber),
                InputValidator.TextValidate(doctor.Address, "Home Address"),
                InputValidator.TextValidate(doctor.HospitalAddress, "Hospital Address"),
                InputValidator.TextValidate(doctor.Experties, "Experties"),
                InputValidator.TextValidate(doctor.Qualification, "Qualification"),
                InputValidator.TextValidate(doctor.Location, "Location")
            };
            if (operation == "INSERT")
            {
                errors.Add(InputValidator.PasswordValidate(doctor.Password));
            }

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

        //RESET INPUTS
        private void ResetInputs()
        {
            first_name_input.Text = "";
            last_name_input.Text = "";
            email_input.Text = "";
            phone_no_input.Text = "";
            password_input.Text = "";
            home_address_input.Text = "";
            hospital_address_input.Text = "";
            expertise_input.Text = "";
            qualification_input.SelectedItem = null;
            location_input.SelectedItem = null;
            password_input.Enabled = true;
            add_doc_btn.Enabled = true;
        }
    }
}
