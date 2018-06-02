using System;
using System.Collections.Generic;

namespace ProblemPlecakowy
{
    public class Plecak
    {
        private double maksymalneObciazenie;
        private List<Pudelko> pudelka;

        public Plecak(double maksymalneObciazenie)
        {
            this.maksymalneObciazenie = maksymalneObciazenie;
            pudelka = new List<Pudelko>();
        }

        public Plecak(Plecak plecak)
        {
            maksymalneObciazenie = plecak.maksymalneObciazenie;
            pudelka = new List<Pudelko>();
            pudelka.AddRange(plecak.pudelka);
        }

        public bool SprobujDodac(Pudelko pudelko)
        {
            if (pudelka.Contains(pudelko))
            {
                return false;
            }

            if ((AktualneObciazenie + pudelko.Waga) <= maksymalneObciazenie)
            {
                pudelka.Add(pudelko);

                return true;
            }

            return false;
        }

        public double MaksymalneObciazenie => maksymalneObciazenie;

        public double AktualneObciazenie
        {
            get
            {
                double rezultat;

                rezultat = 0.0;

                foreach (Pudelko pudelko in pudelka)
                {
                    rezultat += pudelko.Waga;
                }

                return rezultat;
            }
        }

        public double AktualnaWartosc
        {
            get
            {
                double rezultat;

                rezultat = 0.0;

                foreach (Pudelko pudelko in pudelka)
                {
                    rezultat += pudelko.Wartosc;
                }

                return rezultat;
            }
        }

        public List<Pudelko> Pudelka => pudelka;
    }
}
