using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class StaffForm : Form
    {
        //VARIABLES
        private DataGridView staffDataGrid;
        private DBCon dBCon = new DBCon();
        private StaffMemeber staffMemeber;
        private bool isMemeberSelected = false;
        private Int64 selectedMemberID;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            //DISABLE BUTTONS
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
            staffDataGrid = StaffDataGridView;
            LoadStaffData();
        }

        //LOAD STAFF DATA FROM DATABASE AND DISPLAY IT IN DATAGRIDVIEW
        private void LoadStaffData()
        {
            try
            {
                SqlConnection sqlConnection = dBCon.SqlConnection;
                sqlConnection.Open();
                string query =
                    "SELECT Users.id, Users.first_name, Users.last_name, Users.email, Users.role, "
                    + "StaffProfiles.contact_no, StaffProfiles.address "
                    + "FROM Users LEFT JOIN StaffProfiles ON Users.id = StaffProfiles.user_id "
                    + "WHERE Users.role = 'admin' OR Users.role = 'staff'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                staffDataGrid.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("loadStaffData():  " + ex.Message);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string selectedRole = RoleComoboBox.Text.ToLower();
            //MEMEBER OBJECT
            staffMemeber = new StaffMemeber(
                First_name_input.Text,
                Last_name_input.Text,
                Email_input.Text,
                Phone_no_input.Text,
                Password_input.Text,
                Address_input.Text,
                selectedRole
            );

            //FORM VALIDATION
            bool isValid = Validation();
            if (isValid)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Memeber Added Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadStaffData(); // REFRESH DATA GRID VIEW
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
            string selectedRole = RoleComoboBox.Text.ToLower();
            //MEMEBER OBJECT WITHOUT PASSWORD
            staffMemeber = new StaffMemeber(
                First_name_input.Text,
                Last_name_input.Text,
                Email_input.Text,
                Phone_no_input.Text,
                "null",
                Address_input.Text,
                selectedRole
            );

            //FORM VALIDATION
            bool isValid = Validation("UPDATE");
            if (isValid)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedMemberID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Memeber Updated Successfully", "Success", default, MessageBoxIcon.Information);
                    LoadStaffData(); // REFRESH DATA GRID VIEW
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
            if (isMemeberSelected)
            {
                var confirmation = MessageBox.Show(
                    "Are You Sure You Want To Delete This Member?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmation == DialogResult.Yes)
                {
                    bool sqlQueryStatus = DBDeleteQuery(selectedMemberID);
                    if (sqlQueryStatus)
                    {
                        MessageBox.Show("Member Deleted Successfully", "Success", default, MessageBoxIcon.Information);
                        LoadStaffData(); // REFRESH DATA GRID VIEW

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
            isMemeberSelected = false;
            selectedMemberID = 0;
        }

        //HANDLE DATA GRID VIEW CELL CLICK
        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return; // RETURN IF HEADER CLICKED

            isMemeberSelected = true;
            Update_btn.Enabled = true;
            Delete_btn.Enabled = true;
            Password_input.Enabled = false;

            DataGridViewRow selectedRow = StaffDataGridView.Rows[e.RowIndex];
            selectedMemberID = Int64.Parse(selectedRow.Cells[0].Value.ToString());
            First_name_input.Text = selectedRow.Cells[1].Value.ToString();
            Last_name_input.Text = selectedRow.Cells[2].Value.ToString();
            Email_input.Text = selectedRow.Cells[3].Value.ToString();
            Phone_no_input.Text = selectedRow.Cells[5].Value.ToString();
            Address_input.Text = selectedRow.Cells[6].Value.ToString();

            string role = selectedRow.Cells[4].Value.ToString();
            if (role == "admin")
            {
                RoleComoboBox.SelectedIndex = 0;
            }
            else
            {
                RoleComoboBox.SelectedIndex = 1;
            }

            Add_btn.Enabled = false;
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

                // INSERT AND UPDATE USER TABLE

                SqlCommand userTableCmd = staffMemeber.GetInsertCommand(sqlCon);
                if (operationType == "UPDATE")
                {
                    userTableCmd = staffMemeber.GetUpdateCommand(sqlCon, updateID);
                }
                userTableCmd.Transaction = sqlTransaction;
                Int64 userID = Convert.ToInt64(userTableCmd.ExecuteScalar()); // USER ID ADDED TO DATABASE

                // INSERT AND UPDATE STAFF PROFILE TABLE
                SqlCommand staffTableCmd = staffMemeber.GetStaffInsertCommand(sqlCon, userID);
                if (operationType == "UPDATE")
                {
                    staffTableCmd = staffMemeber.GetStaffUpdateCommand(sqlCon, updateID);
                }
                staffTableCmd.Transaction = sqlTransaction;
                staffTableCmd.ExecuteNonQuery();
                sqlTransaction.Commit(); //COMMIT
            }
            catch (Exception ex)
            {
                //ROLLBACK TRANSACTION
                sqlTransaction?.Rollback();

                Console.WriteLine("DBQuery(): ", ex.Message);
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
                StaffMemeber staffMemeber = new StaffMemeber();
                SqlConnection sqlConnection = dBCon.SqlConnection;
                sqlConnection.Open();
                SqlCommand deleteStaffProfileCmd = staffMemeber.GetStaffDeleteCommand(sqlConnection, id);
                SqlCommand deleteUserCmd = staffMemeber.GetDeleteCommand(sqlConnection, id);
                deleteStaffProfileCmd.ExecuteNonQuery();
                deleteUserCmd.ExecuteNonQuery();
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
                InputValidator.TextValidate(staffMemeber.FirstName, "First Name"),
                InputValidator.TextValidate(staffMemeber.LastName, "Last Name"),
                InputValidator.EmailValidate(staffMemeber.Email),
                InputValidator.PhoneValidation(staffMemeber.PhoneNumber),
                InputValidator.TextValidate(staffMemeber.Address, "Address"),
                InputValidator.TextValidate(staffMemeber.Role, "Role")
            };

            if (operation == "INSERT")
            {
                errors.Add(InputValidator.PasswordValidate(staffMemeber.Password));
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

        //RESET INPUT FIELDS
        private void ResetInputs()
        {
            First_name_input.Text = "";
            Last_name_input.Text = "";
            Email_input.Text = "";
            Phone_no_input.Text = "";
            Address_input.Text = "";
            Password_input.Text = "";
            //RESET ADD BUTTON AND FIELDS
            Add_btn.Enabled = true;
            Update_btn.Enabled = false;
            Delete_btn.Enabled = false;
            Password_input.Enabled = true;
        }
    }
}
