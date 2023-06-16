using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_funkcja_e
{
    class Program
    {
        static double obliczanieSilni (int liczba)
        {
            double wynik = 1;
            for (int i = 2; i <= liczba; i++)
            {
                wynik *= i;
            }
            return wynik;

        }
        static double funkcjaWykladnicza(double x, int n)
        {
            double wynik = 0;
            for (int i = 0; i <= n; i++)
            {
                double warunek = Math.Pow(x, i) / obliczanieSilni(i);
            }
            return wynik;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość x: ");
            double x = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę wyrazów n: ");
            int n = int.Parse(Console.ReadLine());

            double wartoscWykladnicza = funkcjaWykladnicza(x, n);

            Console.WriteLine($"Wartość funkcji e^{x} dla n = {n} wynosi: {wartoscWykladnicza}");
            Console.ReadLine();


        }
    }
}
