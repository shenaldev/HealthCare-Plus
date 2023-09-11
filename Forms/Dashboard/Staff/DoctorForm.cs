using HealthCare_Plus.Utils;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Staff
{
    public partial class DoctorForm : Form
    {
        //VARIABLES
        DataGridView doctorGridView;
        private string NameText = null;
        private string EmailText = null;
        private string SpecializationText = null;
        private string LocationText = null;
        private string selectQuery =
            "SELECT Users.id, Users.first_name, Users.last_name, Users.email, DoctorProfiles.qualification, DoctorProfiles.specialization, DoctorProfiles.contact_no, DoctorProfiles.location, DoctorProfiles.home_address,DoctorProfiles.hospital_address FROM Users INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id";

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            doctorGridView = doctorsDataGridView;
            LoadDoctorsData();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            SetInputValues();

            //CHECK IF SEARCH TERM IS EMPTY
            if (
                string.IsNullOrEmpty(NameText)
                && string.IsNullOrEmpty(EmailText)
                && string.IsNullOrEmpty(SpecializationText)
                && string.IsNullOrEmpty(LocationText)
            )
            {
                MessageBox.Show("Please enter a search term", "Empty Search", default, MessageBoxIcon.Error);
                return;
            }

            //SEARCH DOCTORS QUERY
            string searchQuery = selectQuery;
            if (!string.IsNullOrEmpty(EmailText))
            {
                searchQuery += " WHERE email = @email";
            }
            if (!string.IsNullOrEmpty(NameText))
            {
                searchQuery += " AND first_name LIKE @name";
            }
            if (!string.IsNullOrEmpty(SpecializationText))
            {
                searchQuery += " AND specialization LIKE @specialization";
            }
            if (!string.IsNullOrEmpty(LocationText))
            {
                searchQuery += " AND location LIKE @location";
            }

            try
            {
                DBCon dBCon = new DBCon();
                SqlConnection sqlCon = dBCon.SqlConnection;
                sqlCon.Open();

                //EXECUTE SEARCH COMMAND AND FILL DATA TABLE
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, sqlCon);

                if (!string.IsNullOrEmpty(EmailText))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@email", EmailText);
                }
                if (!string.IsNullOrEmpty(NameText))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + NameText + "%");
                }
                if (!string.IsNullOrEmpty(SpecializationText))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@specialization", "%" + SpecializationText + "%");
                }
                if (!string.IsNullOrEmpty(LocationText))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@location", "%" + LocationText + "%");
                }
                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();

                //CHECK IF DOCTORS FOUND
                if (dataTabel.Rows.Count == 0)
                {
                    MessageBox.Show("No doctors found", "No Results", default, MessageBoxIcon.Information);
                    return;
                }

                doctorGridView.DataSource = dataTabel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            LoadDoctorsData();
        }

        //LOAD DOCTORS DATA INTO GRID VIEW
        private void LoadDoctorsData()
        {
            try
            {
                DBCon dBCon = new DBCon();
                SqlConnection sqlCon = dBCon.SqlConnection;
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();
                doctorGridView.DataSource = dataTabel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        //SET INPUT VALUES TO VARIABLES
        private void SetInputValues()
        {
            NameText = Name_input.Text;
            EmailText = Email_input.Text;
            SpecializationText = Specialization_Input.Text;
            LocationText = Location_input.Text;
        }

        //RESET INPUT FIELDS
        private void ResetInputFields()
        {
            Name_input.Text = "";
            Email_input.Text = "";
            Specialization_Input.SelectedItem = null;
            Location_input.SelectedItem = null;
        }
    }
}
