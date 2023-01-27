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
        public static string Reg_pattern6 = "^[A-Z]{1,}[a-zA-Z]{7,}([0-9]+)?$";

        public static bool validatePassword2(string password)
        {
            return Regex.IsMatch(password, Reg_pattern6);

        }

    }
}
