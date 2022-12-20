using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_1_Valid_Emails
{
    public class Pattern
    {
        public static string REGEX_CODE = @"^([a-z]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_CODE);
        }
    }
}
