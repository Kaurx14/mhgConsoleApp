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
    }
}
