using mhgConsoleApp;

namespace mhgConsoleApp
{
    static class Program
    {
        public static Menu menu = new Menu();
        public static Inventory inventory = new Inventory();

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
                             Console.WriteLine(pizza.name + ", Hind: " + pizza.hind);
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
                         Console.WriteLine(Inventory.GetInventory());
                     }
                 }
            }
        }
    }
}