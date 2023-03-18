namespace mhgConsoleApp
{
    public class Pizza
    {
        public string name;
        public float hind;
        public koostisosa[] koostisosadList;
        public enum koostisosa
        {
            pitsapõhi,
            kaste,
            juust,
            pepperoni,
            rukola,
            salami,
            kana,
            sink,
            šampinjonid,
            oliivid,
            hakkliha,
            ananass,

        }

        public Pizza(string name, float hind, koostisosa[] koostisosa)
        {
            this.name = name;
            this.hind = hind;
            this.koostisosadList = koostisosa;
        }
        
    }
}
