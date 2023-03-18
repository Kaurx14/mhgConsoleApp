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
                string command = Console.ReadLine();

                käsklus.DetermineCommand(command);
            }
        }
    }
}