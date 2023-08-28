using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus.Models
{
    public sealed class AuthUser
    {
        private static AuthUser instance = null;
        private string email;
        private string firstName;
        public string role;

        public string Email { get =>  email; set => email = value; }
        public string FirstName { get  => firstName; set => firstName = value; }
        private AuthUser() { }

        public static AuthUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthUser();
                }
                return instance;
            }
        }

    }
}
