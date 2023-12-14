using System;

namespace Ex1c
{
    class Program
    {
        static void Main(string[] args)
        {
            const int noMarks = 4;
            int[] marks = new int[4];
            double total = 0, average;

            for (int i = 0; i < noMarks; i++)
            {
                Console.Write($"Enter mark no {(i + 1)}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            foreach (int mark in marks)
            {
                total += mark;
            }

            average = total / noMarks;

            Console.WriteLine($"Total: {total}, Average: {average}");


            Console.ReadLine();
        }
    }
}
