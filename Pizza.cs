namespace mhgConsoleApp
{
    public class Pizza
    {
        public string name;
        public float hind;
        public koostisosad[] koostisosadList;
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
            this.koostisosadList = koostisosad;
        }
        
    }
}
