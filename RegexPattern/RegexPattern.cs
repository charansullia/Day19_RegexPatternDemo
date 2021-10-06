using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class RegexPattern
    {
        public static string Regex_Pattern = "^[A-z][a-z]{2,}$";

        public bool ValidatePattern(string Pattern)
        {
            return Regex.IsMatch(Pattern, Regex_Pattern);
        }
    }
}
