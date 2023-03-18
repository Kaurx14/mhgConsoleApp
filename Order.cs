using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Order
    {
        public void OnPizzaBought(Pizza orderedPizza)
        {
            Money.money += 1;

            var koostisosad = orderedPizza.koostisosadList;

            if(koostisosad.Contains(Pizza.koostisosad.pepperoni))
            {
                Inventory.pepperoni -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosad.juust))
            {
                Inventory.juust -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosad.tomatikaste))
            {
                Inventory.tomatikaste -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosad.rukola))
            {
                Inventory.tomatikaste -= 1;
            }

        }
    }
}
