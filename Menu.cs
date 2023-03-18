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
            pizzaList.Add(new Pizza("Pepperoni", (Money.pepperoniTkHind + Money.juustTkHind + Money.tomatikasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.tomatikaste }));
            pizzaList.Add(new Pizza("Rukola", (Money.rukolaTkHind + Money.juustTkHind + Money.tomatikasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.rukola, Pizza.koostisosa.tomatikaste }));
            pizzaList.Add(new Pizza("Pepperoni & Rukola", (Money.pepperoniTkHind + Money.juustTkHind + Money.tomatikasteTkHind + Money.rukolaTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.rukola, Pizza.koostisosa.tomatikaste }));
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

        public void AddNewPizzaToMenu()
        {
            Console.WriteLine("Sisesta uue pitsa nimi: ");

            string pizzaName = Console.ReadLine();

            Console.WriteLine("Sisesta uue pitsa koostisosad, eraldades need komaga: ");

            string pitsaKoostisosad = Console.ReadLine();
            pitsaKoostisosad = pitsaKoostisosad.ToLower();
            List<string> koostisosad = SplitSentenceToList(pitsaKoostisosad);
            float currentPizzaHind = 0;
            List<Pizza.koostisosa> uuePitsaKoostisosad = new List<Pizza.koostisosa>();

            if (koostisosad.Contains("pepperoni"))
            {
                currentPizzaHind += Money.pepperoniTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.pepperoni);
            }
            if (koostisosad.Contains("juust"))
            {
                currentPizzaHind += Money.juustTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.juust);
            }
            if (koostisosad.Contains("tomatikaste"))
            {
                currentPizzaHind += Money.tomatikasteTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.tomatikaste);
            }

            if (koostisosad.Contains("rukola"))
            {
                currentPizzaHind += Money.rukolaTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.rukola);
            }

            Pizza.koostisosa[] lõppPitsaKoostisosad = ListToArray<Pizza.koostisosa>(uuePitsaKoostisosad);


            pizzaList.Add(new Pizza("pizzaName", currentPizzaHind * 1.2f, lõppPitsaKoostisosad));
        }

        public List<string> SplitSentenceToList(string command)
        {
            string[] words = command.Split(',');
            List<string> wordsConvertedToList = ArrayToList<string>(words);
            return wordsConvertedToList;
        }

        public List<T> ArrayToList<T>(T[] arr)
        {
            List<T> list = new List<T>(arr);
            return list;
        }

        public T[] ListToArray<T>(List<T> list)
        {
            T[] array = list.ToArray();
            return array;
        }
    }
}
