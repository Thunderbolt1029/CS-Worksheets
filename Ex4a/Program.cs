using System;

namespace Ex4a
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.Write("Word to reverse: ");
            inputString = Console.ReadLine();

            Console.WriteLine($"Reversed word: {reverseString(inputString)}\t\t{(isPalindrome(inputString) ? "Palindrome" : "Not a Palindrome")}");
            Console.ReadLine();
        }

        static bool isPalindrome(string inpString)
        {
            return inpString == reverseString(inpString);
        }

        static string reverseString(string inpString)
        {
            string outString = "";

            for (int i = inpString.Length-1; i >= 0; i--)
            {
                outString += inpString[i];
            }

            return outString;
        }
    }
}
