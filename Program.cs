using mhgConsoleApp;

namespace mhgConsoleApp
{
    static class Program
    {
        public static Menu menu = new Menu();
        public static Inventory inventory = new Inventory();
        public static Money money = new Money();
        public static Order order = new Order();

        public static string OrderedPizzaName;

        static void Main(string[] args)
        {
            Console.WriteLine("Program started!");

            while (true)
            {
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

                             Console.WriteLine("");
                             Console.WriteLine("");
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
                         foreach (var pizza in menu.pizzaList)
                         {
                             if (pizza.name == OrderedPizzaName)
                             {
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
                         Console.WriteLine("Sisestage korrektne pitsa nimi!");
                     }
                     else if (verifiedCommand == "RESTOCK")
                     {
                         
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
    }
}