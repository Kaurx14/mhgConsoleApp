using mhgConsoleApp;

namespace mhgConsoleApp
{
    static class Program
    {
        public static Menu menu = new Menu();
        public static Inventory inventory = new Inventory();
        public static Money money = new Money();
        public static Order order = new Order();
        public static Restock restock = new Restock();

        public static string OrderedPizzaName;
        public static string OrderedKoostisosa;
        public static string OrderedKoostisosaAmount;

        static void Main(string[] args)
        {
            Console.WriteLine("Program started!");

            while (true)
            {
                ConsoleSpace();
                Console.WriteLine("Sisestage käsklus: ");
                string userCommand = Console.ReadLine();

                 string verifiedCommand = käsklus.VerifyCommand(userCommand);

                 if (verifiedCommand == null)
                 {
                     Console.WriteLine("Käsklus ei ole korrektne!");
                 }
                 else
                 {
                     if (verifiedCommand == "MENU")
                     {
                         List<Pizza> pizzas = menu.GetPizzaList();

                         foreach (Pizza pizza in pizzas)
                         {
                             Console.WriteLine(pizza.name + ", Hind: " + pizza.hind + "€");
                             Console.WriteLine("Koostisosad: ");
                             foreach (var koostisosa in pizza.koostisosadList)
                             {
                                 Console.WriteLine(koostisosa);
                             }

                             ConsoleSpace();
                        }
                     }
                     else if (verifiedCommand == "INVENTORY")
                     {
                         Console.WriteLine(inventory.GetInventory());
                     }
                     else if (verifiedCommand == "MONEY")
                     {
                         Console.WriteLine(money.GetMoney());
                     }
                     else if (verifiedCommand == "ORDER")
                     { 
                         bool pizzaFound = false;

                         foreach (var pizza in menu.pizzaList)
                         {
                             if (pizza.name == OrderedPizzaName)
                             {
                                 pizzaFound = true;
                                 OrderedPizzaName = "";
                                 order.OnPizzaBought(pizza);
                                 Console.WriteLine("Tellitud pitsa: " + pizza.name);
                                 Console.WriteLine("Pitsa hind: " + pizza.hind + "€");
                                 Console.WriteLine("Koostisosad: ");
                                 foreach (var koostisosa in pizza.koostisosadList)
                                 {
                                     Console.WriteLine(koostisosa);
                                 }
                                 break;
                             }
                         }

                         if (!pizzaFound)
                         {
                             Console.WriteLine("Sisestage korrektne pitsa nimi!");
                         }

                         ConsoleSpace();
                     }
                     else if (verifiedCommand == "RESTOCK")
                     {
                         if (CheckIfKoostisosaIsValid())
                         {

                         }
                         else
                         {
                             Console.WriteLine("");
                         }

                         restock.RestockInventory();
                     }
                     else if (verifiedCommand == "ADD PIZZA")
                     {
                         
                     }
                     else if (verifiedCommand == "HISTORY")
                     {
                         
                     }
                     else if (verifiedCommand == "SOLD")
                     {
                         
                     }
                 }
            }
        }

        private static void ConsoleSpace()
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private static bool CheckIfKoostisosaIsValid()
        {
            bool isValid = false;

            if (OrderedKoostisosa == "juust")
            {
                isValid = true;
            }
            else if (OrderedKoostisosa == "pepperoni")
            {
                isValid = true;
            }
            else if (OrderedKoostisosa == "rukola")
            {
                isValid = true;
            }
            else if (OrderedKoostisosa == "tomatikaste")
            {
                isValid = true;
            }

            return isValid;
        }
    }
}