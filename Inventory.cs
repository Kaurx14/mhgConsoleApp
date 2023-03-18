using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Inventory
    {
        public static int pepperoni = 10;
        public static int rukola = 10;
        public static int juust = 10;
        public static int tomatikaste = 10;

        public string GetInventory()
        {
            string inventory = "Poes olevad koostisosad: \n \n" + "Pepperoni: " + pepperoni + "\n Rukola: " + rukola + "\n Juust: " + juust + "\n Tomatikaste: " + tomatikaste;

            return inventory;
        }
    }
}
