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
        public static string OrderedPizzaTag;
        public static Pizza.koostisosa ChosenKoostisosa;
        public static string OrderedKoostisosaAmount;
        public static int ChosenKoostisosaAmount;
        public static string ChosenPizzaTag;

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
                             Console.WriteLine(pizza.name + ", Hind: " + pizza.hind.ToString("0.0") + "$");
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
                                 Pizza newPizza = DealWithPizzaTags(pizza);

                                 OrderedPizzaName = "";
                                 OrderedPizzaTag = "";
                                 order.OnPizzaBought(newPizza);
                                 Console.WriteLine("Tellitud pitsa: " + newPizza.name);
                                 Console.WriteLine("Pitsa hind: " + newPizza.hind + "$");
                                 if (ChosenPizzaTag != "")
                                 {
                                     Console.WriteLine("Erisoov: " + ChosenPizzaTag);
                                 }
                                 Console.WriteLine("Koostisosad: ");
                                 foreach (var koostisosa in newPizza.koostisosadList)
                                 {
                                     Console.WriteLine(koostisosa);
                                 }

                                 ChosenPizzaTag = "";

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
                             ChosenKoostisosaAmount = 0;
                         }
                         else
                         {
                             Console.WriteLine("Sisetage korrektne koostisosa ja korrektne kogus.");
                         }
                     }
                     else if (verifiedCommand == "ADD PIZZA")
                     {
                         menu.AddNewPizzaToMenu();
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
            else if (OrderedKoostisosa == "kaste")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.kaste;
            }
            else if (OrderedKoostisosa == "pitsapõhi")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.pitsapõhi;
            }
            else if (OrderedKoostisosa == "oliivid")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.oliivid;
            }
            else if (OrderedKoostisosa == "šampinjonid")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.šampinjonid;
            }
            else if (OrderedKoostisosa == "kana")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.kana;
            }
            else if (OrderedKoostisosa == "salami")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.salami;
            }
            else if (OrderedKoostisosa == "sink")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.sink;
            }
            else if (OrderedKoostisosa == "hakkliha")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.hakkliha;
            }
            else if (OrderedKoostisosa == "ananass")
            {
                isValid = true;
                ChosenKoostisosa = Pizza.koostisosa.ananass;
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

        private static Pizza DealWithPizzaTags(Pizza orderedPizza)
        {
            List<Pizza.koostisosa> uuedKoostisosad = new List<Pizza.koostisosa>();

            foreach (var koostisosa in orderedPizza.koostisosadList)
            {
                uuedKoostisosad.Add(koostisosa);
            }

            if (OrderedPizzaTag == "vegan")
            {
                if (uuedKoostisosad.Contains(Pizza.koostisosa.kana))
                {
                    uuedKoostisosad.Remove(Pizza.koostisosa.kana);
                    orderedPizza.hind -= Money.kanaTkHind;
                }

                if (uuedKoostisosad.Contains(Pizza.koostisosa.salami))
                {
                    uuedKoostisosad.Remove(Pizza.koostisosa.salami);
                    orderedPizza.hind -= Money.salamiTkHind;
                }

                if (uuedKoostisosad.Contains(Pizza.koostisosa.sink))
                {
                    uuedKoostisosad.Remove(Pizza.koostisosa.sink);
                }

                ChosenPizzaTag = "vegan";
            }
            else if (OrderedPizzaTag == "gluteenivaba")
            {
                if (uuedKoostisosad.Contains(Pizza.koostisosa.pitsapõhi))
                {
                    uuedKoostisosad.Remove(Pizza.koostisosa.pitsapõhi);
                    //orderedPizza.hind -= Money.pitsapõhiTkHind;
                }

                ChosenPizzaTag = "gluteenivaba";

                uuedKoostisosad.Add(Pizza.koostisosa.gluteenivabaPitsapõhi);
                //orderedPizza.hind += Money.gluteenivabaPitsapõhiTkHind;
            }
            else if (OrderedPizzaTag == "laktoosivaba")
            {
                if (uuedKoostisosad.Contains(Pizza.koostisosa.juust))
                {
                    uuedKoostisosad.Remove(Pizza.koostisosa.juust);
                    orderedPizza.hind -= Money.juustTkHind;
                }

                ChosenPizzaTag = "laktoosivaba";
            }
            else
            {
                ChosenPizzaTag = "";
            }

            orderedPizza.koostisosadList = menu.ListToArray(uuedKoostisosad);

            return orderedPizza;
        }
    }
}