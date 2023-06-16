using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_algorytm_newton
{
    class Program
    {
        static int silnia(int liczba)
        {
            int wynik = 1;
            for (int i = 2; i <=liczba; i++)
            {
                wynik *= i;
            }
            return wynik;

        }
        static void Main(string[] args)
        {
            int n, k;

            do
            {
                Console.WriteLine("Podaj wartość n (większą bądź równą 5): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 5);

            do
            {
                Console.WriteLine("Podaj wartość k (większą bądź równą 5: ");
                k = int.Parse(Console.ReadLine());
            } while (k < 5);

            int silnia1 = silnia(n);
            int silnia2 = silnia(k);

            int m = (silnia1 - silnia2) / silnia2;

            Console.WriteLine($"Wartość m = {silnia1 - silnia2} / {silnia2} wynosi: {m}");
            Console.ReadLine();

        }
    }
}
