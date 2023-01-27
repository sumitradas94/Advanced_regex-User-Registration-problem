using UserRegistrationProblem;

namespace UserRegistrarionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Mobile Number : ");
            string Monumber = Console.ReadLine();
            bool val4 = Pattern.validateMobileNumber(Monumber);

            if (val4)
            {
                Console.WriteLine("Mobile Number is Valid.");
            }
            else
            {
                Console.WriteLine("Mobile Number is not Valid.");

            }



        }
    }
}
