using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labfour
{
    class Program
    {
        static void Main(string[] args)

        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the factorial calculator!");
                Console.WriteLine("Enter an integer thats greater than 0 but less than 10");

                int i, number, factorial;
                number = int.Parse(Console.ReadLine());
                factorial = number;

                for (i = number - 1; i >= 1; i--)

                { factorial = factorial * i; }

                Console.WriteLine("The factorial of {0} is {1}", number, +factorial); Console.ReadLine();

                run = Continue();
            }
        }
    static bool Continue()
        {
            Console.WriteLine("Do you wish to continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;

            if (input == "y")

            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}
        
