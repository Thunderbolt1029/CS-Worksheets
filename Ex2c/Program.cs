using System;

namespace Ex2c
{
    class Program
    {
        static void Main(string[] args)
        {
            const int topRate = 82;
            const int midRate = 72;
            const int lowRate = 62;
            const int budgetRate = 52;

            float totalMiles, engineSize;
            float allowance;


            totalMiles = intValidation("Input distance travelled: ");
            engineSize = intValidation("Input engine size: ");


            if (totalMiles>100 && engineSize>=2000)
            {
                allowance = (topRate * totalMiles) / 100;
            }
            else if (totalMiles>100 && engineSize<2000)
            {
                allowance = (midRate * totalMiles) / 100;
            }
            else if (totalMiles<=100 && engineSize>=2000)
            {
                allowance = (lowRate * totalMiles) / 100;
            }
            else
            {
                allowance = (budgetRate * totalMiles) / 100;
            }

            Console.WriteLine($"Employee recieves an allowance of £{allowance}");


            Console.ReadLine();
        }

        static int intValidation(string outMessage)
        {
            string input;

            do
            {
                Console.Write(outMessage);
                input = Console.ReadLine();

            } while (!isInt(input));

            return int.Parse(input);
        }

        static bool isInt(string inpInt)
        {
            bool isInt = int.TryParse(inpInt, out int _);

            if (!isInt)
            {
                Console.WriteLine("That's not a number silly\n");
            }

            return isInt;
        }
    }
}
