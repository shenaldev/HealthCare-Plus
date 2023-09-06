namespace HealthCare_Plus.Models
{
    internal class Patient
    {
        private string first_name;
        private string last_name;
        private string email;
        private string phone_no;
        private string address;
        private string disease;

        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNo { get => phone_no; set => phone_no = value; }
        public string Address { get => address; set => address = value; }
        public string Disease { get => disease; set => disease = value; }

        public Patient(string first_name, string last_name, string email, string phone_no, string address, string disease)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_no = phone_no;
            this.address = address;
            this.disease = disease;
        }
    }
}
