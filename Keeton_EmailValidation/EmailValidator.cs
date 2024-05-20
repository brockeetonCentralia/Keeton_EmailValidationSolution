using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeton_EmailValidation
{
    public class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');    
            string local = email.Substring(0, atIndex);
            string domain = email.Substring(atIndex + 1); 

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            if (local.Length < 1 || local.Length > 100)
            {
                return false;
            }

            if (domain.Length > 100 || domain.Length < 3)
            {
                return false;
            }

            if (email.Contains(" "))
            {
                return false;
            }

            if (!email.Contains('@'))
            {
                return false;
            }

            if (dotIndex <= atIndex + 1 || dotIndex >= email.Length - 1)
            {
                return false;
            }

            if (!char.IsLetterOrDigit(local[0]) || !char.IsLetterOrDigit(local[local.Length - 1]))
            {
                return false;
            }

            if (!char.IsLetterOrDigit(domain[0]) || !char.IsLetterOrDigit(domain[domain.Length - 1])) 
            { 
                return false; 
            }

            return true;
        }
    }
}
