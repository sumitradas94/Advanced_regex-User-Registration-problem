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
        public static string Reg_pattern5 = "^[a-zA-Z]{8,}([0-9]+)?$";

        public static bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Reg_pattern5);

        }
    }
}

