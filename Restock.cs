using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Restock
    {
        public float restockingPrice = 0;

        public void RestockInventory(Pizza.koostisosa koostisosa, int kogus)
        {
            if (koostisosa == Pizza.koostisosa.pepperoni)
            {
                Inventory.pepperoni += kogus;
                restockingPrice = kogus * Money.pepperoniTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.juust)
            {
                Inventory.juust += kogus;
                restockingPrice = kogus * Money.juustTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.rukola)
            {
                Inventory.rukola += kogus;
                restockingPrice = kogus * Money.rukolaTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.kaste)
            {
                Inventory.kaste += kogus;
                restockingPrice = kogus * Money.kasteTkHind;
                Money.money -= restockingPrice;
            }
        }
    }
}
