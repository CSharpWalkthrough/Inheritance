using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Exercice.Models
{
    public class WeaponSmith:Villager
    {
        public WeaponSmith():base() 
        {
            TradeCost = 10;
        }

        public void CraftWeapon() => Console.WriteLine("Villager is crafting weapon.");
        public void Attack() => Console.WriteLine("Villager is attacking zombie.");
    }
}
