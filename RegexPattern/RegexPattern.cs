using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class RegexPattern
    {
        public static string Regex_Pattern = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool ValidatePattern(string Pattern)
        {
            return Regex.IsMatch(Pattern, Regex_Pattern);
        }
    }
}
