using System;

namespace Ex3d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number\tSquare\tCube");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }


            Console.ReadLine();
        }
    }
}
