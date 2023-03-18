using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Restock
    {


        public static void RestockInventory(Pizza.koostisosa koostisosa, int kogus)
        {
            if(koostisosa == Pizza.koostisosa.pepperoni)
            {
                Inventory.pepperoni += kogus;
                Money.money -= kogus * Money.pepperoniTkHind;

            }
            if (koostisosa == Pizza.koostisosa.juust)
            {
                Inventory.juust += kogus;
                Money.money -= kogus * Money.juustTkHind;
            }
            if (koostisosa == Pizza.koostisosa.rukola)
            {
                Inventory.rukola += kogus;
                Money.money -= kogus * Money.rukolaTkHind;
            }
            if (koostisosa == Pizza.koostisosa.pepperoni)
            {
                Inventory.tomatikaste += kogus;
                Money.money -= kogus * Money.pepperoniTkHind;
            }
        }
    }
}
