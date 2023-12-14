using System;

namespace Ex3f
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer;
            int timesTable = intValidation("Times table to be tested: ");
            int randomNumber = rnd.Next(1, timesTable+1);

            answer = intValidation($"{timesTable} x {randomNumber} = ");

            if (timesTable*randomNumber==answer)
            {
                Console.WriteLine("gg bro");
            }
            else
            {
                Console.WriteLine("Wrongggggggg\n");
                Console.Beep(175, 800);

                Console.WriteLine("Learn these dumbass:");
                for (int i = 1; i <= timesTable; i++)
                {
                    Console.WriteLine($"{timesTable} x {i} = {timesTable * i}");
                }
            }
            

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
