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
        public static string Reg_pattern8 = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$";

        public static bool validatePassword4(string password)
        {
            return Regex.IsMatch(password, Reg_pattern8);

        }

    }
}


