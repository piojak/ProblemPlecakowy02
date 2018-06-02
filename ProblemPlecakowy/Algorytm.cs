using System;
using System.Collections.Generic;

namespace ProblemPlecakowy
{
    
    public class Algorytm
    {
       
        public Plecak Szukaj(Plecak aktualne, List<Pudelko> pudelka)
        {
            bool aktualizacja;

            
            RozwiazanieLosowe(aktualne, pudelka);

            
            while (true)
            {
                // flaga mówiąca czy dokonano aktualizacji maksimum
                aktualizacja = false;

                // pętla dla wszystkich rozwiązań sąsiednich
                foreach (Plecak sasiedni in RozwiazaniaSasiednie(aktualne, pudelka))
                {
                    
                    if (aktualne.AktualnaWartosc < sasiedni.AktualnaWartosc)
                    {
                        
                        aktualne = sasiedni;
                        aktualizacja = true;
                    }
                }

                // przerwij pętlę jeżeli nie było aktualizacji maksimum
                if (!aktualizacja)
                {
                    break;
                }
            }

            // zwróć wynik
            return aktualne;
        }

        
        public void RozwiazanieLosowe(Plecak plecak, List<Pudelko> pudelka)
        {
            int i, j, k;
            Random random;
            Pudelko t;

            random = new Random();

            for (i = 0; i < pudelka.Count; i++)
            {
                j = random.Next(pudelka.Count);
                k = random.Next(pudelka.Count);
                t = pudelka[j];
                pudelka[j] = pudelka[k];
                pudelka[k] = t;
            }

            for (i = 0; i < pudelka.Count; i++)
            {
                plecak.SprobujDodac(pudelka[i]);
            }
        }

        
        public List<Plecak> RozwiazaniaSasiednie(Plecak plecak, List<Pudelko> pudelka)
        {
            List<Plecak> rozwiazania;
            Plecak rozwiazanie;
            int i, j;

            rozwiazania = new List<Plecak>();
            
            for (i = 0; i < plecak.Pudelka.Count; i++)
            {
                rozwiazanie = new Plecak(plecak);
                rozwiazanie.Pudelka.RemoveAt(i);

                for (j = 0; j < pudelka.Count; j++)
                {
                    rozwiazanie.SprobujDodac(pudelka[j]);
                }

                rozwiazania.Add(rozwiazanie);
            }

            return rozwiazania;
        }
    }
}
