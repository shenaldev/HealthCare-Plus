using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HealthCare_Plus.Utils
{
    internal class InputValidator
    {
        //VARIABLES
        private string value;
        private string label;

        public InputValidator(string value, string label)
        {
            this.value = value;
            this.label = label;
        }

        // VALIDATE ALL TEXT INPUTS
        public static string TextValidate(string value, string label)
        {
            if (string.IsNullOrEmpty(value))
            {
                return label + " is a required field";
            }
            if (value.Length < 2)
            {
                return label + " must be at least 2 charactors";
            }
            return "valid";
        }

        // VALIDATE EMAIL INPUTS
        public static string EmailValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Email is a required field";
            }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(value))
            {
                return "Invalid email address";
            }
            return "valid";
        }

        // VALIDATE PASSWORD INPUTS
        public static string PasswordValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Password is a required field";
            }
            if (value.Length < 8)
            {
                return "Password must be at least 8 charactors";
            }
            return "valid";
        }

        // VALIDATE PHONE INPUTS
        public static string PhoneValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Phone number is a required field";
            }
            if (value.Length > 10)
            {
                return "Phone number must be 10 charactors";
            }
            if (value.Length < 10)
            {
                return "Phone number must be 10 charactors";
            }
            string phonePattern = @"^(\d{10})$";
            Regex regex = new Regex(phonePattern);
            if (!regex.IsMatch(value))
            {
                return "Invalid phone number";
            }
            return "valid";
        }

        // VALIDATE DATE INPUTS
        public static string DateValidate(DateTime value, string label, string timeLine)
        {
            if (value == null)
            {
                return label + " is a required field";
            }
            if (timeLine == "future")
            {
                if (value < DateTime.Now)
                {
                    return label + " must be in the future date";
                }
            }
            else
            {
                if (value > DateTime.Now)
                {
                    return label + " must be a past date";
                }
            }
            return "valid";
        }

        //VALIDATE SELECTIONS
        public static string SelectionValidate(string value, string label, bool validateZero = false)
        {
            if (string.IsNullOrEmpty(value))
            {
                return label + " is a required field";
            }

            //VALIDATE INVALID NUMBER
            bool isValidNumber = int.TryParse(value, out int result);
            if (isValidNumber)
            {
                if (result < 0)
                {
                    return label + " invalid selection";
                }
            }

            if (validateZero)
            {
                if (value == "0")
                {
                    return label + " is a required field";
                }
            }

            return "valid";
        }

        // VALIDATE NUMBERS
        public static string NumberValidate(string value, string label)
        {
            if (string.IsNullOrEmpty(value))
            {
                return label + " is a required field";
            }

            bool isValidNumber = int.TryParse(value, out int result);
            if (isValidNumber)
            {
                if (result < 0)
                {
                    return label + " invalid number";
                }
            }

            string numberPattern = @"^(\d+)$";
            Regex regex = new Regex(numberPattern);
            if (!regex.IsMatch(value))
            {
                return label + " must be a number";
            }
            return "valid";
        }
    }
}
