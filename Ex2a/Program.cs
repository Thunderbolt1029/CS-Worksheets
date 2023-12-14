using System;

namespace Ex2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the temperature: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp > 25)
            {
                Console.WriteLine("HOT");
            }
            else
            {
                Console.WriteLine("COLD");
            }


            Console.ReadLine();
        }
    }
}
