namespace ProblemPlecakowy
{
    
    public class Pudelko
    {
        private double waga;
        private double wartosc;

        public Pudelko(double waga, double wartosc)
        {
            this.waga = waga;
            this.wartosc = wartosc;
        }

        public double Waga => waga;
        public double Wartosc => wartosc;
    }
}
