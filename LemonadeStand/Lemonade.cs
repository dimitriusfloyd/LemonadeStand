using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Lemonade : Stands
    {
        public string NameOfStand { get; set; }
        public int NumberOfCups { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public decimal Revenue()
        {
            return Price * NumberOfCups;
        }
        public decimal Profit()
        {

            return Price - Cost;
        }

    }
}
