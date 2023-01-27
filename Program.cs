using UserRegistrationProblem;

namespace UserRegistrarionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Password : ");
            string password = Console.ReadLine();
            bool val7 = Pattern.validatePassword3(password);

            if (val7)
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
