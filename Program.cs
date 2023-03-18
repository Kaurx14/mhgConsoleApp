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
        public static Pizza.koostisosa ChosenKoostisosa;
        public static string OrderedKoostisosaAmount;
        public static int ChosenKoostisosaAmount;

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
                             Console.WriteLine(pizza.name + ", Hind: " + pizza.hind.ToString("0.0") + "€");
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
                         if (CheckIfKoostisosaIsValid() && CheckIfKoostisosaAmountIsValid())
                         {
                             restock.RestockInventory(ChosenKoostisosa, ChosenKoostisosaAmount);
                             Console.WriteLine("Koostisosa " + ChosenKoostisosa + " on juurde tellitud koguses " + ChosenKoostisosaAmount + ". Hind oli " + restock.restockingPrice + ".");
                         }
                         else
                         {
                             Console.WriteLine("Sisetage korrektne koostisosa ja korrektne kogus.");
                         }
                     }
                     else if (verifiedCommand == "ADD PIZZA")
                     {
                         menu.Ad
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
                ChosenKoostisosa = Pizza.koostisosa.juust;
            }
            else if (OrderedKoostisosa == "pepperoni")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.pepperoni;
            }
            else if (OrderedKoostisosa == "rukola")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.rukola;
            }
            else if (OrderedKoostisosa == "tomatikaste")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.tomatikaste;
            }

            return isValid;
        }

        private static bool CheckIfKoostisosaAmountIsValid()
        {
            bool isValid = false;

            try
            {
                int amount = int.Parse(OrderedKoostisosaAmount);

                if (amount > 0)
                {
                    ChosenKoostisosaAmount = amount;
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}