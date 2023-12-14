using System;

namespace Ex2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int examMark, courseworkMark;


            courseworkMark = intValidation("Enter coursework mark: ");
            examMark = intValidation("Enter exam mark: ");


            if (examMark>70 && courseworkMark>80) 
            {
                Console.WriteLine("Overall distinction");
            }
            else if (examMark>=40 && courseworkMark>80 || examMark>70 && courseworkMark>=40)
            {
                Console.WriteLine("Overall merit");
            }
            else if (examMark>=40 && courseworkMark>=40)
            {
                Console.WriteLine("Overall pass");
            }
            else
            {
                Console.WriteLine("Overall fail");
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
