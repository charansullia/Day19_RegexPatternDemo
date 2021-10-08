using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class RegexPattern
    {
        public static string Regex_Pattern = "^([A-Za-z0-9])*([/+-@_&$#])?([A-Za-z0-9])*$";

        public bool ValidatePattern(string Pattern)
        {
            return Regex.IsMatch(Pattern, Regex_Pattern);
        }
    }
}
