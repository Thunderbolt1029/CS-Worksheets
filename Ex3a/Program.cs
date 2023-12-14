using System;

namespace Ex3a
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numOfMarks = 4;
            int[] examMarks = new int[numOfMarks];
            float total = 0, average;

            for (int i = 0; i < numOfMarks; i++)
            {
                Console.Write($"Enter mark no {i + 1}: ");
                examMarks[i] = int.Parse(Console.ReadLine());

                total += examMarks[i];
            }
            average = total / numOfMarks;

            Console.WriteLine($"Total: {total}, Average: {average}");

      
            Console.ReadLine();
        }
    }
}
