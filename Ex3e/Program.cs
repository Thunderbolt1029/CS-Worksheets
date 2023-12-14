using System;

namespace Ex3e
{
    class Program
    {
        static void Main(string[] args)
        {
            int _base, power;

            _base = intValidation("Base: ");
            power = intValidation("Power: ");

            Console.WriteLine($"{_base} ^ {power} = {pow(_base, power)}");


            Console.ReadLine();
        }

        static int pow(int _base, int power)
        {
            int ans = 1;
            for (int i = 0; i < power; i++)
            {
                ans*=_base;
            }
            return ans;
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
