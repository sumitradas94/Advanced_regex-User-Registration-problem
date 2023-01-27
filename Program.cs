using UserRegistrationProblem;

namespace UserRegistrarionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Password : ");
            string password = Console.ReadLine();
            bool val6 = Pattern.validatePassword2(password);

            if (val6)
            {
                Console.WriteLine("Password is Correct.");
            }
            else
            {
                Console.WriteLine("Password is not Correct.");

            }




        }
    }
}