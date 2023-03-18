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
            pizzaList.Add(new Pizza("Pepperoni", 5.00f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.tomatikaste }));
            pizzaList.Add(new Pizza("Rukola", 5.50f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.rukola, Pizza.koostisosa.tomatikaste }));
            pizzaList.Add(new Pizza("Pepperoni & Rukola", 6.00f, new Pizza.koostisosa[] { Pizza.koostisosa.juust, Pizza.koostisosa.pepperoni, Pizza.koostisosa.rukola, Pizza.koostisosa.tomatikaste }));
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
