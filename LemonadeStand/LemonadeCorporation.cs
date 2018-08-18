using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeCorporation
    {
        List<Lemonade> lemonadestands = new List<Lemonade>();

        public static decimal CorpRevenue { get; set; }
        public static decimal CorpExpepnses { get; set; }
        public static decimal CorpProfit { get; set; }

        public decimal Revenue()
        {
            decimal totalRevenue = 0;
            foreach(Lemonade stand in lemonadestands)
            {
                totalRevenue += stand.Revenue();
            }

            return totalRevenue;
        }

        public decimal Profit(decimal Price, decimal Cost)
        {

            return Price - Cost;
        }

    }
}
