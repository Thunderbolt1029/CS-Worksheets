using System;

namespace Ex5b
{
    class Program
    {
        static void Main(string[] args)
        {
            const int noStudents = 4;
            string[,] studentMarks = new string[noStudents, 2];
            float total = 0, average;
            int highestMarkStudent = 0, lowestMarkStudent = 0;

            for (int i = 0; i < noStudents; i++)
            {
                Console.Write("Student ID: ");
                studentMarks[i, 0] = Console.ReadLine();

                Console.Write("Student Mark: ");
                studentMarks[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < noStudents; i++)
            {
                total += int.Parse(studentMarks[i, 1]);
            }
            average = total / noStudents;

            for (int i = 0; i < noStudents; i++)
            {
                highestMarkStudent = int.Parse(studentMarks[i, 1]) > int.Parse(studentMarks[highestMarkStudent, 1]) ? i : highestMarkStudent;
                lowestMarkStudent = int.Parse(studentMarks[i, 1]) < int.Parse(studentMarks[lowestMarkStudent, 1]) ? i : lowestMarkStudent;
            }

            Console.WriteLine($"\nTotal: {total}, Average: {average}");
            Console.WriteLine($"The highest marking student was student {studentMarks[highestMarkStudent, 0]} with {studentMarks[highestMarkStudent, 1]} marks");
            Console.WriteLine($"The lowest marking student was student {studentMarks[lowestMarkStudent, 0]} with {studentMarks[lowestMarkStudent, 1]} marks");


            Console.ReadLine();
        }
    }
}
