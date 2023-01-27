using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Pattern
    {

        public static string REGEX_PAT = "^[A-Z]{1}[a-zA-Z0-9]{2,20}$";
        public static bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_PAT);
        }
    }
}