using System;

namespace Ex3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfMarks;
            Console.Write("How many students in the class? ");
            numOfMarks = int.Parse(Console.ReadLine());

            int[] examMarks = new int[numOfMarks];
            float total = 0, average;

            for (int i = 0; i < numOfMarks; i++)
            {
                Console.Write($"Enter mark no {i + 1}: ");
                examMarks[i] = int.Parse(Console.ReadLine());

                total += examMarks[i];
            }
            average = total / numOfMarks;

            Console.WriteLine($"Total: {total}, Average: {average}, Lowest: {lowestArrValue(examMarks)}, Highest: {highestArrValue(examMarks)}");


            Console.ReadLine();
        }

        static int lowestArrValue(int[] array)
        {
            int lowest = int.MaxValue;

            foreach (int value in array)
            {
                lowest = (value < lowest) ? value : lowest;
            }

            return lowest;
        }

        static int highestArrValue(int[] array)
        {
            int highest = int.MinValue;

            foreach (int value in array)
            {
                highest = (value > highest) ? value : highest;
            }

            return highest;
        }
    }
}
