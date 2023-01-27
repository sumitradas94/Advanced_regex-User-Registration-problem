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
        public static string Reg_pattern3 = "^(abc)(.[A-Za-z]+)*@(bl).(co)([.][a-z]{2,})?$";

        public static bool validateEmailID(string email)
        {
            return Regex.IsMatch(email, Reg_pattern3);
        }

    }
}
