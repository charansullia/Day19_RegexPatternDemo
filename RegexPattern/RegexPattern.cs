using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class RegexPattern
    {
        public static string Regex_Pattern = "^[1-9]{2}[ ][0-9]{10}$";

        public bool ValidatePattern(string Pattern)
        {
            return Regex.IsMatch(Pattern, Regex_Pattern);
        }
    }
}
