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
            string[] section = email.Split('@');
            string username = section[0];
            string charDomain = section[1];
            string[] section2 = email.Split('.');
            string domain = section2[1];
            int atIndex = email.IndexOf('@');
            int dotIndex = email.IndexOf('.', atIndex);
            string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~@!$%^&*_=+}{\\'?-.";

            if (email == "")
            {
                return false;
            }

            if (username.Length > 100)
            {
                return false;
            }

            if (charDomain.Length > 100 || domain.Length < 3)
            {
                return false;
            }

            if (email.Contains(" "))
            {
                return false;
            }

            if (email.Contains("@") == false || email.Contains(".") == false)
            {
                return false;
            }

            if (atIndex !> 0 && dotIndex !< atIndex)
            {
                return false;
            }

            if (char.IsLetter(email[0]) == false || char.IsLetter(email[email.Length - 1]) == false)
            {
                return false;
            }

            foreach (char c in email)
            {
                if (validChar.Contains(c) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
