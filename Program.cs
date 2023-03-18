using mhgConsoleApp;

namespace mhgConsoleApp
{
    class Program
    {
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

                     }
                 }
            }
        }
    }
}