using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus.Models
{
    internal class Patient
    {
        public string first_name;
        public string last_name;
        public string email;
        public string phone_no;
        public string password;
        public string address;

        public Patient(string first_name, string last_name, string email, string phone_no, string password, 
            string address) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_no = phone_no;
            this.password = password;
            this.address = address;
        }
    }
}
