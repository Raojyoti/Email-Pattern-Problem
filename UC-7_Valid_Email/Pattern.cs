using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_7_Valid_Email
{
    public class Pattern
    {
        public static string REGEX_CODE = @"^([a-z]+)?@([1]+)\.([a-z\,]{2,})$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_CODE);
        }
    }
}
