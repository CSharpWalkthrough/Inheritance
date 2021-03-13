using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Exercice.Models
{
    public class Farmer : Villager
    {
        public Farmer(int nbEmeralds)
        {
            NbEmeralds = nbEmeralds;
            TradeCost = DEFAULT_TRADE_COST;
        }

        public void PlantSeeds() => Console.WriteLine("Villager is planting seeds");

        public void HarvestSeeds() => Console.WriteLine("Villager is harvesting seeds");
    }
}
