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
        public static string Reg_pattern7 = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}([0-9]+)?$";

        public static bool validatePassword3(string password)
        {
            return Regex.IsMatch(password, Reg_pattern7);

        }

    }
}


