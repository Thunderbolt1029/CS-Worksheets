using System;

namespace Ex4b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splitSentence;
            string searchWord;
            int occurences = 0;

            Console.Write("Enter your sentence: ");
            splitSentence = Console.ReadLine().ToLower().Split(' ');

            Console.Write("Enter your search word: ");
            searchWord = Console.ReadLine().ToLower();

            foreach (string word in splitSentence)
            {
                occurences += (searchWord == word) ? 1 : 0;
            }

            Console.WriteLine($"Number of times search word found was {occurences}");


            Console.ReadLine();
        }
    }
}
