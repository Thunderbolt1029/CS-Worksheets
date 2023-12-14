using System;

namespace Ex2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your parent? (m, f, or say a tragic story of how you are orphaned): ");
            String character = Console.ReadLine().ToLower();

            switch (character)
            {
                case "m":
                    Console.WriteLine("You have a dad, well done");
                    break;

                case "f":
                    Console.WriteLine("mommy?");
                    break;

                default:
                    Console.WriteLine("Stupid little orphan boy");
                    break;
            }


            Console.ReadLine();
        }
    }
}
