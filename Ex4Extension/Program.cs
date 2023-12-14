using System;
using System.Linq;

namespace Ex4cExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyz.";

            string emailAddress;
            string[] splitEmailAddress = new string[3];
            bool oneAtSign, noSpace, onlyLettersAfterDot, threeSectionsHaveValue;

            do
            {
                Console.Write("Enter your email address: "); 
                emailAddress = Console.ReadLine().ToLower();


                oneAtSign = emailAddress.Split('@').Length - 1 == 1;
                noSpace = !emailAddress.Contains(' ');


                splitEmailAddress[0] = emailAddress.Split('@')[0];
                splitEmailAddress[1] = emailAddress.Split('@')[1];
                splitEmailAddress[2] = concat(splitEmailAddress[1]
                                                                .Split('.', 2)
                                                                .Skip(1)
                                                                .ToArray());
                splitEmailAddress[1] = splitEmailAddress[1].Split('.')[0];

                threeSectionsHaveValue = true;
                foreach (string section in splitEmailAddress)
                {
                    threeSectionsHaveValue = section=="" ? false : threeSectionsHaveValue;
                }

                onlyLettersAfterDot = true;
                foreach (char character in splitEmailAddress[2])
                {
                    onlyLettersAfterDot = !allowedChars.Contains(character) ? false : onlyLettersAfterDot;
                }


                string output = "";
                output += oneAtSign ? "" : "Too may @ signs\t\t";
                output += noSpace ? "" : "Should have no Spaces\t\t";
                output += threeSectionsHaveValue ? "" : "There should be text before and after the @ symbol with a prefix after the dot\t\t";
                output += onlyLettersAfterDot ? "" : "Should have only letters after the first dot after the @ sign\t\t";

                if (output!="")
                {
                    Console.WriteLine("Not a valid email");
                    Console.WriteLine(output);
                    Console.WriteLine("");
                }

            } while (!oneAtSign || !noSpace || !threeSectionsHaveValue || !onlyLettersAfterDot);

            Console.WriteLine($"{emailAddress} is valid");


            Console.ReadLine();
        }

        static string concat(string[] stringArray)
        {
            string concatString = "";

            foreach (string _string in stringArray)
            {
                concatString += _string;
            }

            return concatString;
        }
    }
}
