using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Restock
    {
        public float restockingPrice = 0;

        public void RestockInventory(Pizza.koostisosa koostisosa, int kogus)
        {
            if (koostisosa == Pizza.koostisosa.pitsapõhi)
            {
                Inventory.pitsapõhi += kogus;
                restockingPrice = kogus * Money.pizzapõhiTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.juust)
            {
                Inventory.juust += kogus;
                restockingPrice = kogus * Money.juustTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.rukola)
            {
                Inventory.rukola += kogus;
                restockingPrice = kogus * Money.rukolaTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.kaste)
            {
                Inventory.kaste += kogus;
                restockingPrice = kogus * Money.kasteTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.pepperoni)
            {
                Inventory.pepperoni += kogus;
                restockingPrice = kogus * Money.pepperoniTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.salami)
            {
                Inventory.salami += kogus;
                restockingPrice = kogus * Money.salamiTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.kana)
            {
                Inventory.kana += kogus;
                restockingPrice = kogus * Money.kanaTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.sink)
            {
                Inventory.sink += kogus;
                restockingPrice = kogus * Money.sinkTkHInd;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.šampinjonid)
            {
                Inventory.šampinjonid += kogus;
                restockingPrice = kogus * Money.šampinjonidTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.oliivid)
            {
                Inventory.oliivid += kogus;
                restockingPrice = kogus * Money.oliividTkHind;
                Money.money -= restockingPrice;
            }

            if (koostisosa == Pizza.koostisosa.hakkliha)
            {
                Inventory.hakkliha += kogus;
                restockingPrice = kogus * Money.hakklihaTkHind;
                Money.money -= restockingPrice;
            }
            if (koostisosa == Pizza.koostisosa.ananass)
            {
                Inventory.ananass += kogus;
                restockingPrice = kogus * Money.ananassTkHind;
                Money.money -= restockingPrice;
            }


        }
    }
}
