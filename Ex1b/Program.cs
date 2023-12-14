using System;

namespace Ex1b
{
    class height
    {
        public int feet;
        public int inches;

        public int inchTotal
        {
            get
            {
                return (feet * 12) + inches;
            }
        }

        public height(int inpFeet, int inpInches)
        {
            feet = inpFeet; 
            inches = inpInches;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in feet then in inches: ");
            height userHeight = new height(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Your height is " + userHeight.inchTotal + " inches");


            Console.ReadLine();
        }
    }
}
