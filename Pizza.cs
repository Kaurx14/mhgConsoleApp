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

        public Pizza(string name, float hind, List<koostisosad> koostisosad)
        {
            this.name = name;
            this.hind = hind;
            this.koostisosadList = koostisosad;
        }
        
    }
}
