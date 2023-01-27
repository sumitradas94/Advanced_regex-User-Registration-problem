using UserRegistrationProblem;

namespace UserRegistrarionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Password : ");
            string password = Console.ReadLine();
            bool val5 = Pattern.validatePassword(password);

            if (val5)
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