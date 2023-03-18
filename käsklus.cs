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
            if (command.StartsWith("O"))
            {
                command.ToUpper();

                string[] commandText = SplitSentence(command);

                if (commandText.Length > 1)
                {
                    Program.OrderedPizzaName = commandText[1];
                }

                return commandText[0];
            }

            if (command.StartsWith("R"))
            {
                command.ToUpper();

                string[] commandText = SplitSentence(command);

                if (commandText.Length > 1)
                {
                    Program.OrderedKoostisosa = commandText[1];
                }

                if (commandText.Length > 2)
                {
                    Program.OrderedKoostisosaAmount = commandText[2];
                }

                return commandText[0];
            }

            command = command.ToUpper();

            if (commands.Contains(command)) return command;
            else return null;
        }

        public static string[] SplitSentence(string command)
        {
            string[] words = command.Split(' ');

            return words;
        }
    }
}
