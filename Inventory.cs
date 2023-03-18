using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Inventory
    {
        public static int pitsapõhi = 10;
        public static int gluteenivabaPitsapõhi = 10;
        public static int juust = 10;
        public static int kaste = 10;
        public static int pepperoni = 10;
        public static int rukola = 10;
        public static int salami = 10;
        public static int kana = 10;
        public static int sink = 10;
        public static int šampinjonid = 10;
        public static int oliivid = 10;
        public static int hakkliha = 10;
        public static int ananass = 10;


        public string GetInventory()
        {
            string inventory = "Poes olevad koostisosad: \n \n" + "Pepperoni: " + pepperoni + "\n Rukola: " + rukola + "\n Juust: " + juust + "\n Kaste: " + kaste;

            return inventory;
        }
    }
}
