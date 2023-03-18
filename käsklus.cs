using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public static class käsklus
    {
        public static string[] commands = { "MENU", "INVENTORY", "MONEY", "ORDER", "RESTOCK", "ADD PIZZA", "HISTORY", "SOLD" };
        public static string VerifyCommand(string command)
        {
            command = command.ToUpper();

            if (commands.Contains(command))
                return command;
            else 
                return null;

            return null;

            return null;
        }
    }
}
