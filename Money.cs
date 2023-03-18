using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Money
    {
        public static int money = 10;

        public static string GetMoney()
        {
            string raha = "Poes olev raha: " + money + "€";
            return raha;
        }
    }
}
