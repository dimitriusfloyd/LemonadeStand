using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Lemonade myStand = new Lemonade();
            myStand.NameOfStand = "Good Lemonade";
            myStand.NumberOfCups = 100;
            myStand.Price = 1;
            myStand.Cost = .25;

            Console.WriteLine("Welcome!");
            Console.WriteLine("What will the name of your lemonade stand be?");
            string NameOfStand = Console.ReadLine();

            Console.WriteLine("Thanks!");
            Console.WriteLine("Your stand will be called " + NameOfStand);

            Console.WriteLine("How many cups will you sell:");
            int NumberOfCups = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Thanks!");
            Console.WriteLine("How much will you sell each cup for?");

            decimal Price = Int32.Parse(Console.ReadLine());
            decimal Revenue = NumberOfCups * 
        }
    }

