using System.Text.RegularExpressions;

namespace HealthCare_Plus.Utils
{
    internal class CCValidation
    {
        //VALIDATE CREDIT NUMBER
        public static string CardNubmerValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Credit card number is a required field";
            }
            if (value.Length > 16)
            {
                return "Credit card number must be 16 charactors";
            }
            if (value.Length < 16)
            {
                return "Credit card number must be 16 charactors";
            }
            string creditCardPattern = @"^(\d{16})$";
            Regex regex = new Regex(creditCardPattern);
            if (!regex.IsMatch(value))
            {
                return "Invalid credit card number";
            }
            return "valid";
        }

        //VALIDATE CREDIT CARD EXPIRY DATE
        public static string ExpDateValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Expiry date is a required field";
            }
            string expDatePattern = @"^(0[1-9]|1[0-2])\/?([0-9]{4}|[0-9]{2})$";
            Regex regex = new Regex(expDatePattern);
            if (!regex.IsMatch(value))
            {
                return "Invalid expiry date";
            }
            return "valid";
        }

        //VALIDATE CREDIT CARD CVV
        public static string CVVNumberValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "CVV is a required field";
            }
            if (value.Length > 3)
            {
                return "CVV must be 3 charactors";
            }
            if (value.Length < 3)
            {
                return "CVV must be 3 charactors";
            }
            string cvvPattern = @"^(\d{3})$";
            Regex regex = new Regex(cvvPattern);
            if (!regex.IsMatch(value))
            {
                return "Invalid CVV";
            }
            return "valid";
        }
    }
}
