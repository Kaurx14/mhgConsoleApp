using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Money
    {
        public static float money = 1000;

        public static float pepperoniTkHind = 1f;
        public static float juustTkHind = 2.5f;
        public static float rukolaTkHind = 1.0f;
        public static float pizzapõhiTkHind = 1.5f;
        public static float gluteenivabaPitsapõhiTkHind = 3f;
        public static float kasteTkHind = 0.7f;
        public static float salamiTkHind = 2f;
        public static float kanaTkHind = 2.5f;
        public static float sinkTkHInd = 2.2f;
        public static float ananassTkHind = 2.0f;
        public static float oliividTkHind = 2.5f;
        public static float hakklihaTkHind = 1.2f;
        public static float shampinjonidTkHind = 3f;

        public string GetMoney()
        {
            string raha = "Poes olev raha: " + money + "€";
            return raha;
        }
    }
}
