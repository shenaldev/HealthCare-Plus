using System.Security.Cryptography;
using System.Text;

namespace HealthCare_Plus.Utils
{
    internal class Hash
    {
        public string HashPassword(string password)
        {
            string inputPassword = password;
            byte[] inputPasswordByte = ASCIIEncoding.ASCII.GetBytes(inputPassword);
            byte[] hashPassword = new SHA256CryptoServiceProvider().ComputeHash(inputPasswordByte);
            return ByteArrayToString(hashPassword);
        }

        private static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        /*
         * VERIFY HASHED PASSWORD MACHES INPUT PASSWORD
         * @params inputPassword = user input password
         * @params passwordHash = database hashed password
         */
        public bool VerifyPassword(string inputPassword, string passwordHash)
        {
            bool isValid = false;

            byte[] inputPasswordByte = ASCIIEncoding.ASCII.GetBytes(inputPassword);
            byte[] inputPasswordHash = new SHA256CryptoServiceProvider().ComputeHash(inputPasswordByte);

            if (ByteArrayToString(inputPasswordHash) == passwordHash)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
