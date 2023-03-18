using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Menu
    {
        public List<Pizza> menu = new List<Pizza>();
        public Menu()
        {
            menu.Add(new Pizza("Pepperoni", 5.00f, new Pizza.koostisosad[] { Pizza.koostisosad.juust, Pizza.koostisosad.pepperoni, Pizza.koostisosad.tomatikaste }));
            menu.Add(new Pizza("Rukola", 5.50f, new Pizza.koostisosad[] { Pizza.koostisosad.juust, Pizza.koostisosad.rukola, Pizza.koostisosad.tomatikaste }));
            menu.Add(new Pizza("Pepperoni & Rukola", 6.00f, new Pizza.koostisosad[] { Pizza.koostisosad.juust, Pizza.koostisosad.pepperoni, Pizza.koostisosad.rukola, Pizza.koostisosad.tomatikaste }));
        }
        public Pizza GetPizza(string name)
        {
            foreach (Pizza pizza in menu)
            {
                if (pizza.name == name)
                    return pizza;
            }
            return null;
        }
    }
}
