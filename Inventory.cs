using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Inventory
    {
        public static int pitsapõhi = 100;
        public static int gluteenivabaPitsapõhi = 100;
        public static int juust = 100;
        public static int kaste = 100;
        public static int pepperoni = 100;
        public static int rukola = 100;
        public static int salami = 100;
        public static int kana = 100;
        public static int sink = 100;
        public static int shampinjonid = 100;
        public static int oliivid = 100;
        public static int hakkliha = 100;
        public static int ananass = 100;


        public string GetInventory()
        {
            string inventory = "Poes olevad koostisosad: \n \n" + "Pepperoni: " + pepperoni + "\n Rukola: " + rukola + "\n Juust: " + juust + "\n Kaste: " + kaste + "\n Pitsapõhi: " +
                pitsapõhi + "\n Gluteenivaba pitsapõhi: " + gluteenivabaPitsapõhi + "\n Salami: " + salami + "\n Kana: " + kana + "\n Sink: " + sink + "\n Shampinjonid: " + shampinjonid +
                "\n Oliivid: " + oliivid + "\n Hakkliha: " + hakkliha + "\n Ananass: " + ananass;

            return inventory;
        }
    }
}
