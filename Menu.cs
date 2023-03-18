using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Menu
    {
        public List<Pizza> pizzaList = new List<Pizza>();
        public Menu()
        {
            pizzaList.Add(new Pizza("Pepperoni", (Money.pepperoniTkHind + Money.juustTkHind + Money.tomatikasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.kaste }));
            pizzaList.Add(new Pizza("Rukola", (Money.rukolaTkHind + Money.juustTkHind + Money.tomatikasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.rukola, Pizza.koostisosa.kaste }));
            pizzaList.Add(new Pizza("Pepperoni & Rukola", (Money.pepperoniTkHind + Money.juustTkHind + Money.tomatikasteTkHind + Money.rukolaTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.rukola, Pizza.koostisosa.kaste }));
        }

        public List<Pizza> GetPizzaList()
        {
            return pizzaList;
        }

        public Pizza GetPizza(string name)
        {
            foreach (Pizza pizza in pizzaList)
            {
                if (pizza.name == name)
                    return pizza;
            }
            return null;
           
        }

        //public Pizza AddNewPizzaToMenu()
        //{
        //    Console.WriteLine("Sisesta uue pitsa nimi: ");

        //    string pizzaName = Console.ReadLine();

        //    Console.WriteLine("Sisesta uue pitsa koostisosad, eraldades need komaga: ");

        //    string pitsaKoostisosad = Console.ReadLine();
        //    pitsaKoostisosad = pitsaKoostisosad.ToLower();
        //    List<string> koostisosad = käsklus.SplitSentence(pitsaKoostisosad);

        //    if (koostisosad.Contains("pepperoni"))
        //    {

        //    }

          

        //    pizzaList.Add(new Pizza("pizzaName", (Money.pepperoniTkHind + Money.juustTkHind + Money.tomatikasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.tomatikaste }));
        //}

        //public static List<string> SplitSentenceToList(string command)
        //{
        //    List<string> words = command.Split('');
        //    return words;
        //}

        public List<T> ArrayToList<T>(T[] arr)
        {
            List<T> list = new List<T>(arr);
            return list;
        }
    }
}
