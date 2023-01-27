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
        public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";

        public static bool validateMobileNumber(string Monumber)
        {
            return Regex.IsMatch(Monumber, Reg_pattern4);
        }

    }
}

