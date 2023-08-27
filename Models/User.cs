using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus.Models
{
    internal class User
    {
        private string first_name;
        private string last_name;
        private string email;
        private string phone_no;
        private string password;
        private string address;
        private string role;

        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phone_no; set => phone_no = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string Role { get => role; set => role = value; }

        public User(string first_name, string last_name, string email, string phone_no, string password, 
            string address, string role) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_no = phone_no;
            this.password = password;
            this.address = address;
            this.role = role;
        }


    }
}
