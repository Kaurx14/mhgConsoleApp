using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Order
    {
        public static void OnPizzaBought()
        {
            Money.money += 1;


        }

        //public Pizza.koostisosad[] GetIngredientsOfPizza(Pizza orderedPizza)
        //{
        //    return orderedPizza.koostisosadList;
        //}
    }
}
