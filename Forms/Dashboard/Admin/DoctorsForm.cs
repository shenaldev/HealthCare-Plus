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
        bool isSelectedUser = false;

        public DoctorsForm()
        {
            InitializeComponent();
        }

        //ONLOAD FUNCTION
        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadDoctorDataFromDB();
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        //LOAD DOCTOR DATA INTO DATAGRIDVIEW
        private void LoadDoctorDataFromDB()
        {
            try
            {
                DBCon dBCon = new DBCon();
                SqlConnection sqlCon = dBCon.SqlConnection;
                string query =
                    "SELECT Users.id, Users.first_name, Users.last_name, Users.email, DoctorProfiles.qualification, DoctorProfiles.specialization, DoctorProfiles.contact_no, DoctorProfiles.location, DoctorProfiles.home_address,DoctorProfiles.hospital_address FROM Users INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id";
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
        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return; // RETURN IF HEADER CLICKED

            isSelectedUser = true;
            //ENABLE UPDATE AND DELETE BUTTONS
            update_doc_btn.Enabled = true;
            delete_btn.Enabled = true;

            DataGridViewRow selectedRow = doctorsDataGridView.Rows[e.RowIndex];
            selectedUserID = Int64.Parse(selectedRow.Cells[0].Value.ToString());
            first_name_input.Text = selectedRow.Cells[1].Value.ToString();
            last_name_input.Text = selectedRow.Cells[2].Value.ToString();
            email_input.Text = selectedRow.Cells[3].Value.ToString();
            qualification_input.Text = selectedRow.Cells[4].Value.ToString();
            Specialization_combobox.Text = selectedRow.Cells[5].Value.ToString();
            phone_no_input.Text = selectedRow.Cells[6].Value.ToString();
            location_input.Text = selectedRow.Cells[7].Value.ToString();
            home_address_input.Text = selectedRow.Cells[8].Value.ToString();
            hospital_address_input.Text = selectedRow.Cells[9].Value.ToString();
            password_input.Enabled = false; //DISABLE PASSWORD INPUT
            add_doc_btn.Enabled = false; //DISABLE ADD DOCTOR BUTTON
        }

        //HANDLE ADD DOCTOR BUTTON CLICK
        private void Add_doc_btn_Click(object sender, EventArgs e)
        {
            //DOCTOR OBJECT
            doctor = new Doctor(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                password_input.Text,
                home_address_input.Text,
                "doctor",
                hospital_address_input.Text,
                Specialization_combobox.Text,
                qualification_input.Text,
                location_input.Text
            );

            bool isValidationPassed = Validation();
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Doctor Added Successfully", "Success", default, MessageBoxIcon.Information);
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
        private void Update_doc_btn_Click(object sender, EventArgs e)
        {
            //DOCTOR OBJECT WITHOUT PASSWORD
            doctor = new Doctor(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                "none",
                home_address_input.Text,
                "doctor",
                hospital_address_input.Text,
                Specialization_combobox.Text,
                qualification_input.Text,
                location_input.Text
            );

            bool isValidationPassed = Validation("UPDATE");
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedUserID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Doctor Update Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    isSelectedUser = false;
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                }
            }
        }

        //DELETE BUTTON CLICK HANDLER
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (isSelectedUser)
            {
                var confirmation = MessageBox.Show(
                    "Are You Sure You Want To Delete This Doctor?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmation == DialogResult.Yes)
                {
                    bool sqlQueryStatus = DBDeleteQuery(selectedUserID);
                    if (sqlQueryStatus)
                    {
                        MessageBox.Show("Doctor Deleted Successfully", "Success", default, MessageBoxIcon.Information);
                        LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                        isSelectedUser = false;
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Server Error", default, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Reset_btn_ClickHandler(object sender, EventArgs e)
        {
            ResetInputs();
        }

        //INSERT AND UPDATE QUERY
        private bool DBQuery(string operation, Int64 updateID = 0)
        {
            string operationType = operation == "INSERT" ? "INSERT" : "UPDATE";
            SqlConnection sqlCon = null;
            SqlTransaction sqlTransaction = null;

            try
            {
                DBCon dBCon = new DBCon();
                sqlCon = dBCon.SqlConnection;
                sqlCon.Open();
                sqlTransaction = sqlCon.BeginTransaction(); // TRANSACTION START

                //INSERT AND UPDATE USER TABLE QUERY
                SqlCommand userTableCmd = doctor.GetInsertCommand(sqlCon);
                if (operationType == "UPDATE")
                {
                    userTableCmd = doctor.GetUpdateCommand(sqlCon, updateID);
                }
                userTableCmd.Transaction = sqlTransaction;
                Int64 userID = Convert.ToInt64(userTableCmd.ExecuteScalar()); //EXICUTE CMD

                //INSERT AND UPDATE DOCTOR TABLE QUERY
                SqlCommand doctorTableCmd = doctor.GetDocInsertCmd(sqlCon, userID);
                if (operationType == "UPDATE")
                {
                    doctorTableCmd = doctor.GetDocUpdateCmd(sqlCon, updateID);
                }
                doctorTableCmd.Transaction = sqlTransaction;
                doctorTableCmd.ExecuteNonQuery();
                sqlTransaction.Commit(); //COMMIT
            }
            catch (Exception ex)
            {
                //ROLLBACK TRANSACTION
                if (sqlTransaction != null)
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
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return true;
        }

        //DELETE QUERY
        private bool DBDeleteQuery(Int64 id)
        {
            try
            {
                DBCon dBCon = new DBCon();
                SqlConnection sqlConnection = dBCon.SqlConnection;
                sqlConnection.Open();

                Doctor doctor = new Doctor();
                SqlCommand deleteDoctor = doctor.GetDocDeleteCmd(sqlConnection, id);
                SqlCommand deleteUser = doctor.GetDeleteCommand(sqlConnection, id);
                deleteDoctor.ExecuteNonQuery();
                deleteUser.ExecuteNonQuery();
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
                InputValidator.TextValidate(doctor.FirstName, "First Name"),
                InputValidator.TextValidate(doctor.LastName, "Last Name"),
                InputValidator.EmailValidate(doctor.Email),
                InputValidator.PhoneValidation(doctor.PhoneNumber),
                InputValidator.TextValidate(doctor.Address, "Home Address"),
                InputValidator.TextValidate(doctor.HospitalAddress, "Hospital Address"),
                InputValidator.TextValidate(doctor.Specialization, "Specialization"),
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
            Specialization_combobox.SelectedItem = null;
            qualification_input.SelectedItem = null;
            location_input.SelectedItem = null;
            password_input.Enabled = true;
            add_doc_btn.Enabled = true;
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }
    }
}
