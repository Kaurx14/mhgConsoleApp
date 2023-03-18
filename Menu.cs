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
            pizzaList.Add(new Pizza("Pepperoni", (Money.pepperoniTkHind + Money.juustTkHind + Money.kasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.kaste }));
            pizzaList.Add(new Pizza("Rukola", (Money.rukolaTkHind + Money.juustTkHind + Money.kasteTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.rukola, Pizza.koostisosa.kaste }));
            pizzaList.Add(new Pizza("Napolitana", (Money.pepperoniTkHind + Money.juustTkHind + Money.kasteTkHind + Money.rukolaTkHind + Money.kanaTkHind) * 1.2f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.rukola, Pizza.koostisosa.kaste, Pizza.koostisosa.kana }));
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

            if (pitsaKoostisosad.Contains("pitsapõhi"))
            {
                currentPizzaHind += Money.pizzapõhiTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.pitsapõhi);
            }
            if (pitsaKoostisosad.Contains("juust"))
            {
                currentPizzaHind += Money.juustTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.juust);
            }
            if (pitsaKoostisosad.Contains("kaste"))
            {
                currentPizzaHind += Money.kasteTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.kaste);
            }

            if (pitsaKoostisosad.Contains("rukola"))
            {
                currentPizzaHind += Money.rukolaTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.rukola);
            }
            if (pitsaKoostisosad.Contains("pepperoni"))
            {
                currentPizzaHind += Money.pepperoniTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.pepperoni);
            }
            if (pitsaKoostisosad.Contains("salami"))
            {
                currentPizzaHind += Money.salamiTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.salami);
            }
            if (pitsaKoostisosad.Contains("kana"))
            {
                currentPizzaHind += Money.kanaTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.kana);
            }
            if (pitsaKoostisosad.Contains("sink"))
            {
                currentPizzaHind += Money.sinkTkHInd;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.sink);
            }
            if (pitsaKoostisosad.Contains("šampinjonid"))
            {
                currentPizzaHind += Money.šampinjonidTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.šampinjonid);
            }
            if (pitsaKoostisosad.Contains("oliivid"))
            {
                currentPizzaHind += Money.oliividTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.oliivid);
            }
            if (pitsaKoostisosad.Contains("hakkliha"))
            {
                currentPizzaHind += Money.hakklihaTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.hakkliha);
            }
            if (pitsaKoostisosad.Contains("ananass"))
            {
                currentPizzaHind += Money.ananassTkHind;
                uuePitsaKoostisosad.Add(Pizza.koostisosa.ananass);
            }

            Pizza.koostisosa[] lõppPitsaKoostisosad = ListToArray<Pizza.koostisosa>(uuePitsaKoostisosad);


            pizzaList.Add(new Pizza(pizzaName, currentPizzaHind * 1.2f, lõppPitsaKoostisosad));
            Console.WriteLine("Pitsa \"" + pizzaName + "\" lisatud menüüsse!");
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
