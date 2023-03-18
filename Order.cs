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

            if(koostisosad.Contains(Pizza.koostisosa.pitsapõhi))
            {
                Inventory.pitsapõhi -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.gluteenivabaPitsapõhi))
            {
                Inventory.gluteenivabaPitsapõhi -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.juust))
            {
                Inventory.juust -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.kaste))
            {
                Inventory.kaste -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.pepperoni))
            {
                Inventory.pepperoni -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.rukola))
            {
                Inventory.rukola -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.salami))
            {
                Inventory.salami -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.kana))
            {
                Inventory.rukola -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.sink))
            {
                Inventory.sink -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.šampinjonid))
            {
                Inventory.šampinjonid -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.oliivid))
            {
                Inventory.oliivid -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.hakkliha))
            {
                Inventory.hakkliha -= 1;
            }
            if (koostisosad.Contains(Pizza.koostisosa.ananass))
            {
                Inventory.ananass -= 1;
            }

        }
    }
}
