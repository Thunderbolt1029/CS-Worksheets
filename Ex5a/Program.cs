using System;

namespace Ex5a
{
    class Program
    {
        static void Main(string[] args)
        {
            const int length = 3;
            string[] names = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the next name: ");
                names[i] = Console.ReadLine();
            }

            Console.Write("Forward order: ");
            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }

            Console.Write("\nreverse order: ");
            for (int i = 2; i >= 0; i--)
            {
                Console.Write($"{names[i]}, ");
            }


            Console.ReadLine();
        }
    }
}
