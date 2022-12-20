using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_4_Valid_Email
{
    public class Pattern
    {
        public static string REGEX_CODE = @"^([a-z0-9]+)?@([a-z]+)\.([a-z\,]{2,})$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_CODE);
        }
    }
}
