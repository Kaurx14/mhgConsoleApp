using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Money
    {
        public static float money = 10;

        public static float pepperoniTkHind = 1f;
        public static float tomatikasteTkHind = 2f;
        public static float juustTkHind = 2.5f;
        public static float rukolaTkHind = 0.5f;

        public string GetMoney()
        {
            string raha = "Poes olev raha: " + money + "€";
            return raha;
        }
    }
}
