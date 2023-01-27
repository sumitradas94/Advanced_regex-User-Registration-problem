using UserRegistrationProblem;

namespace UserRegistrarionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Email  ID : ");
            string email = Console.ReadLine();
            bool val3 = Pattern.validateEmailID(email);


            if (val3)
            {
                Console.WriteLine("Email ID is Valid.");
            }
            else
            {
                Console.WriteLine("Email ID is not Valid.");

            }
        }
    }
}