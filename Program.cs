using UserRegistrationProblem;

namespace UserRegistrarionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Password : ");
            string password = Console.ReadLine();
            bool val8 = Pattern.validatePassword4(password);

            if (val8)
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