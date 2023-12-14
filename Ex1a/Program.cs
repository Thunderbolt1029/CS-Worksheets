using System;

namespace Ex1a
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name + " your year of birth is " + (2022 - age));


            Console.ReadLine();
        }
    }
}
