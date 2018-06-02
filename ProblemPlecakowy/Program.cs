using System;
using System.Collections.Generic;

namespace ProblemPlecakowy
{
    // główna klasa programu
    public class Program
    {
        
        public static void Main(string[] args)
        {
            
            List<Pudelko> pudelka;
            Algorytm algorytm;
            Plecak plecak;

            
            pudelka = new List<Pudelko>()
            {
                new Pudelko(12, 4), // 12 kg, 4 zł
                new Pudelko(2, 2), // 2 kg, 2 zł
                new Pudelko(1, 2), // 1 kg, 2 zł
                new Pudelko(1, 1), // 1 kg, 1 zł
                new Pudelko(4, 10), // 4 kg, 10 zł
            };
            
            algorytm = new Algorytm();
            
            plecak = new Plecak(15);
            
            plecak = algorytm.Szukaj(plecak, pudelka);

            
            Console.WriteLine("Obciążenie plecaka: {0}/{1} kg", 
                plecak.AktualneObciazenie, plecak.MaksymalneObciazenie);
            Console.WriteLine("Wartość plecaka: {0} zł", plecak.AktualnaWartosc);
            Console.WriteLine("Pudełka w plecaku => ");

            foreach (Pudelko pudelko in plecak.Pudelka)
            {
                Console.WriteLine("{0} kg, {1} zł", pudelko.Waga, pudelko.Wartosc);
            }

            Console.ReadKey();
        }
    }
}

