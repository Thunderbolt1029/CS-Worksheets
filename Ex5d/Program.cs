using System;
using System.Collections.Generic;

namespace Ex5d
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true) {
                Console.Write("Enter another one (exit with \"$$$\"): ");
                string input = Console.ReadLine();

                if (input=="$$$") { break; }
                else if (int.TryParse(input, out _))
                {
                    list.Add(input + "i");
                }
                else
                {
                    list.Add(input + "s");
                }
            }

            Console.Write("Enter word item to search for: ");
            string searchTerm = Console.ReadLine();

            for (int i = 0; i < list.ToArray().Length; i++)
            {
                if (list[i][list[i].Length-1] == 'i' || list[i][list[i].Length-1] == 's') { list[i] = list[i][0..^1]; }
                if (list[i]==searchTerm)
                {
                    Console.WriteLine($"Item found at index {i}");
                }
            }


            for (int i = list.Count; i >= 0; i++)
            {
                try
                {
                    if (!int.TryParse(list[i], out _)) { list.RemoveAt(i); }
                }
                catch { break; }
            }

            List<int> intList = new List<int>();
            foreach (string element in list)
            {
                if (int.TryParse(element, out _))
                {
                    intList.Add(int.Parse(element));
                }
            }
            

            Console.Write("Sorted ascending or descending (0 or anything else): ");

            intList.Sort();
            if (Console.ReadLine() != "0") { intList.Reverse(); }

            Console.Write("[ ");
            foreach (int element in intList)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine("]");

            Console.ReadLine();
        }
    }
}
