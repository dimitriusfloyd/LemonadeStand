using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Lemonade
    {
        public string NameOfStand { get; set; }
        public int NumberOfCups { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal Revenue (decimal Price, int NumberOfCups)
        {
            return Price * NumberOfCups;
        }
        public decimal Profit (decimal Price, decimal Cost)
        {

            return Price - Cost;
        }

    }
}
