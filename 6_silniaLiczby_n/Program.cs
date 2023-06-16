using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_silniaLiczby_n
{
    class Program
    {
        static int obliczSilnie(int liczba)
        {
            int wynik = 1;
            for (int i =2; i <= liczba; i++) 
            {
                wynik *= i;
            }

            return wynik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę x: ");
            int x = int.Parse(Console.ReadLine());

            int n = 0;
            int silnia = 1;

            while (silnia <= x)
            {
                n++;
                silnia = obliczSilnie(n);

                if (silnia == x)
                {
                    Console.WriteLine($"Liczba {x} jest silnią liczby {n}");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby.");
            Console.ReadLine();
        }
    }
}
