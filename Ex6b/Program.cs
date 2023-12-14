using System;

namespace Parties
{
    // Dinner Party Class
    class BaseParty
    {
        public int NoOfPeople;
        public int FancyDecorations;
        public decimal Cost;

        public static void CalcCostofDecs(int Decorations, ref decimal decsCost)
        {
            decsCost = Convert.ToDecimal(Decorations * 7.50);
        }
    }

    class DinnerParty : BaseParty
    {
        public int HealthyOption;

        public DinnerParty(int _NoOfPeople, int _FancyDecorations, decimal _Cost, int _HealthyOption)
        {
            NoOfPeople = _NoOfPeople;
            FancyDecorations = _FancyDecorations;
            Cost = _Cost;
            HealthyOption = _HealthyOption;
        }

        public static void CalcCostofDrinks(int NoPeople, ref decimal drinksCost)
        {
            drinksCost = Convert.ToDecimal(NoPeople * 10.55);
        }

        public void printDinner()
        {
            Console.WriteLine("Party Details saved are:");
            Console.WriteLine("Number of People:" + NoOfPeople);
            Console.WriteLine("Number of Decorations:" + FancyDecorations);
            Console.WriteLine("Total Cost: £" + Cost);
            Console.WriteLine("NUmber of Healthy Options:" + HealthyOption);
        }
    }

    // Birthday Party Class
    class BirthdayParty : BaseParty
    {
        public int CakeSize;
        public string CakeWriting;

        public BirthdayParty(int _NoOfPeople, int _FancyDecorations, decimal _Cost, int _CakeSize, string _CakeWriting)
        {
            NoOfPeople = _NoOfPeople;
            FancyDecorations = _FancyDecorations;
            Cost = _Cost;
            CakeSize = _CakeSize;
            CakeWriting = _CakeWriting;
        }

        public static void CalcCostofCake(int cakeSize, ref decimal cakeCost)
        {
            cakeCost = Convert.ToDecimal(cakeSize * 4.99);
        }

        public void printBirthday()
        {
            Console.WriteLine("Party Details saved are:");
            Console.WriteLine("Number of People:" + NoOfPeople);
            Console.WriteLine("Number of Decorations:" + FancyDecorations);
            Console.WriteLine("Total Cost: £" + Cost);
            Console.WriteLine("Cake Size:" + CakeWriting);
        }
    }

    class KidsParty : BaseParty
    {
        public bool entertainer;

        public KidsParty(int NoOfPeople, int FancyDecorations, decimal Cost, bool entertainer)
        {
            this.NoOfPeople = NoOfPeople;
            this.FancyDecorations = FancyDecorations;
            this.Cost = Cost;
            this.entertainer = entertainer;
        }

        public static new void CalcCostofDecs(int Decorations, ref decimal decsCost)
        {
            decsCost = Convert.ToDecimal(Decorations * 10);
        }

        public void printParty()
        {
            Console.WriteLine("Party Details saved are:");
            Console.WriteLine("Number of People:" + NoOfPeople);
            Console.WriteLine("Number of Decorations:" + FancyDecorations);
            Console.WriteLine("Total Cost: £" + Cost);
            Console.WriteLine("Entertainer?: " + (entertainer ? "yes" : "no"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal CostofDrinks = 0, CostofDecorations = 0, CostofCake = 0;
            Console.WriteLine("1. for Dinner 2. for Birthday 3. for Kids");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("How many guests ");
                int guests = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Healthy options ");
                int Healthy = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Decorations ");
                int Decs = int.Parse(Console.ReadLine());
                DinnerParty.CalcCostofDrinks(guests, ref CostofDrinks);
                DinnerParty.CalcCostofDecs(Decs, ref CostofDecorations);
                DinnerParty NewmanDinnerParty = new DinnerParty(guests, Decs, CostofDrinks + CostofDecorations, Healthy);
                NewmanDinnerParty.printDinner();
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.WriteLine("How many guests ");
                int guests = int.Parse(Console.ReadLine());
                Console.WriteLine("CakeSize:");
                int CakeSize = int.Parse(Console.ReadLine());
                Console.WriteLine("How many Decorations ");
                int Decs = int.Parse(Console.ReadLine());
                Console.WriteLine("Cake Writing ");
                string CakeMessage = Console.ReadLine();
                BirthdayParty.CalcCostofCake(CakeSize, ref CostofCake);
                BirthdayParty.CalcCostofDecs(Decs, ref CostofDecorations);
                BirthdayParty NewmanBirthdayParty = new BirthdayParty(guests, Decs, CostofCake + CostofDecorations, CakeSize, CakeMessage);
                NewmanBirthdayParty.printBirthday();
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                Console.WriteLine("How many guests ");
                int guests = int.Parse(Console.ReadLine());
                Console.WriteLine("Entertainer? (y or literally anything else):");
                bool entertainer = Console.ReadLine().ToLower() == "y";
                Console.WriteLine("How many Decorations ");
                int Decs = int.Parse(Console.ReadLine());
                KidsParty.CalcCostofDecs(Decs, ref CostofDecorations);
                KidsParty NewmanKidsParty = new KidsParty(guests, Decs, CostofDecorations + (entertainer ? 100 : 0), entertainer);
                NewmanKidsParty.printParty();
                Console.ReadLine();
            }
        }
    }
}