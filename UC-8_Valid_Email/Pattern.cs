using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_8_Valid_Email
{
    public class Pattern
    {
        public static string REGEX_CODE = @"^([a-z]+)?@([a-z]+)\.([a-z]{2,5})(\.[a-z]{3})?$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_CODE);
        }
    }
}
