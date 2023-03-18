using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhgConsoleApp
{
    public class Pizza
    {
        public string name;
        public float hind;
        public List<koostisosad> koostisosadList;
        public enum koostisosad
        {
            juust,
            pepperoni,
            tomatikaste,
            rukola
        }

        public Pizza(string name, float hind, koostisosad[] koostisosad)
        {
            this.name = name;
            this.hind = hind;
            koostisosad = koostisosad;
        }
        
    }
}
