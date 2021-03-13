using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Exercice.Models
{
    public class Villager
    {
        protected const int DEFAULT_TRADE_COST = 5;
        public Villager()
        {
            TradeCost = DEFAULT_TRADE_COST;
        }

        public int TradeCost { get; set; }
        public int NbEmeralds { get; set; }

        public void Trade() => Console.WriteLine("Trade successfully completed.");

        public void PrintNbEmeralds() => Console.WriteLine($"Villager's emeralds are now of {NbEmeralds}.");

    }
}
