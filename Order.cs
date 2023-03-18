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
            Money.money += orderedPizza.hind;

            var koostisosad = orderedPizza.koostisosadList;

            if(koostisosad.Contains(Pizza.koostisosa.pepperoni))
            {
                Inventory.pepperoni -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.juust))
            {
                Inventory.juust -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.tomatikaste))
            {
                Inventory.tomatikaste -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.rukola))
            {
                Inventory.tomatikaste -= 1;
            }

        }
    }
}
