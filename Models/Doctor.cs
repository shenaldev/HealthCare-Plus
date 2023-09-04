using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus.Models
{
    internal class Doctor : User
    {
        private string hospital_address;
        private string experties;
        private string qualification;
        private string location;

        public string HospitalAddress { get => hospital_address; set => hospital_address = value; }
        public string Experties { get => experties; set => experties = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Location { get => location; set => location = value; }

        public Doctor(string first_name,
            string last_name,
            string email,
            string phone_no, 
            string password,
            string address,
            string role, 
            string hospital_address,string experties, string qualification, string location)
            : base(first_name, last_name, email, phone_no, password, address, role)
        {
            this.hospital_address = hospital_address;
            this.experties = experties;
            this.qualification = qualification;
            this.location = location;
        }

    }
}
