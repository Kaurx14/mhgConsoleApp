using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class PizzaList
    {
        public List<Pizza> pizzaList = new List<Pizza>();
        public PizzaList()
        {
            pizzaList.Add(new Pizza("Pepperoni", 5.00f, new Pizza.koostisosad[] { Pizza.koostisosad.juust, Pizza.koostisosad.pepperoni, Pizza.koostisosad.tomatikaste }));
            pizzaList.Add(new Pizza("Rukola", 5.50f, new Pizza.koostisosad[] { Pizza.koostisosad.juust, Pizza.koostisosad.rukola, Pizza.koostisosad.tomatikaste }));
            pizzaList.Add(new Pizza("Pepperoni & Rukola", 6.00f, new Pizza.koostisosad[] { Pizza.koostisosad.juust, Pizza.koostisosad.pepperoni, Pizza.koostisosad.rukola, Pizza.koostisosad.tomatikaste }));
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
