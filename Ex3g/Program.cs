using System;

namespace Ex3g
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(100)+1;
            childBMind childB = new childBMind();

            Console.WriteLine("Child A: I have chosen my number between 1 and 100");
            do
            {
                Console.WriteLine($"Child B: The number is between {childB.lowerBound} and {childB.upperBound} so i guess {childB.guess}");

                if (childB.guess<number)
                {
                    Console.WriteLine("Child A: My number is larger");
                    childB.lowerBound = childB.guess;
                }
                else if (childB.guess > number)
                {
                    Console.WriteLine("Child A: My number is smaller");
                    childB.upperBound = childB.guess;
                }
                else
                {
                    Console.WriteLine($"Child A: Correct, the number I thought of was {number}");
                }

            } while (childB.guess != number);
            Console.WriteLine($"Child B: The number is between {childB.lowerBound} and {childB.upperBound} so i guess {childB.guess}");
            Console.WriteLine($"Child A: Correct, the number I thought of was {number}");


            Console.ReadLine();
        }
    }

    class childBMind
    {
        public int lowerBound;
        public int upperBound;

        public int guess
        {
            get
            {
                return (lowerBound + upperBound) / 2;
            }
        }

        public childBMind()
        {
            lowerBound = 1;
            upperBound = 100;
        } 
    }
}
