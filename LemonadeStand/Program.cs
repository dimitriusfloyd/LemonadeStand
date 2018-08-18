using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Lemonade myStand1 = new Lemonade() { NameOfStand = "Good Lemonade", NumberOfCups = 100, Price = 1, Cost = .25m };
            
            Lemonade myStand2 = new Lemonade();
            myStand2.NameOfStand = "Really Good Lemonade";
            myStand2.NumberOfCups = 200;
            myStand2.Price = 1.50m;
            myStand2.Cost = .50m;

            List<Lemonade> lemonadeStandList = new List<Lemonade>();

            foreach (Lemonade lemonadestand in lemonadeStandList)
            {
                lemonadeStandList.Add(lemonadestand);
            }


            Console.WriteLine("Welcome!");
            Console.WriteLine("What will the name of your lemonade stand be?");
            string NameOfStand = Console.ReadLine();

            Console.WriteLine("Thanks!");
            Console.WriteLine("Your stand will be called " + NameOfStand);

            Console.WriteLine("How many cups will you sell:");
            int NumberOfCups = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Thanks!");
            Console.WriteLine("How much will you sell each cup for?");

            decimal Price = decimal.Parse(Console.ReadLine());
            decimal Revenue = NumberOfCups * Price;
        }
    }
}

