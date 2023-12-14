using System;

namespace Ex3c
{
    class Program
    {
        static void Main(string[] args)
        {
            float total = 0, average;

            int numOfMarks = 0;
            while (true)
            {
                int entry = intValidation($"Enter mark no {numOfMarks+1}: ");
                
                if (entry>=0) { total += entry; numOfMarks++; }
                else { break; }
            }

            average = total / numOfMarks;

            Console.WriteLine($"Total: {total}, Average: {average}");


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
            bool isInt = int.TryParse(inpInt, out _);

            if (!isInt)
            {
                Console.WriteLine("That's not a number silly\n");
            }

            return isInt;      
        }
    }
}
