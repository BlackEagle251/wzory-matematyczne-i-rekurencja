using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_kontoOszczednosciowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kwotę początkową: ");
            decimal kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Podaj oprocentowanie w skali roku (%): ");
            decimal oprocentowanie = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
            int liczbaMiesiecy = int.Parse(Console.ReadLine());

            decimal odsetki = 0;
            decimal kwotaCalkowita = kwotaPoczatkowa;

            for (int i = 1; i <= liczbaMiesiecy; i++)
            {
                odsetki = (kwotaCalkowita * (oprocentowanie / 12));
                kwotaCalkowita += odsetki;
            }

            decimal podatek = obliczPodatek(odsetki);
            decimal kwotaKoncowa = kwotaCalkowita - podatek;
            
            Console.WriteLine($"Kwota zarobiona: {kwotaKoncowa}");
            Console.ReadLine();

        }

        private static decimal obliczPodatek(decimal odsetki)
        {
            const decimal wskaznikPodatku = 0.19M; //19% podatek Belki
            decimal podatek = odsetki * wskaznikPodatku;
            return podatek;
        }
    }
}
