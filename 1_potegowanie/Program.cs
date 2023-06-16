using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_potegowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, p, wynik = 1;
            Console.WriteLine("Podaj liczbę naturalną:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wykładnik potęgi:");
            p = int.Parse(Console.ReadLine());
            for (int i = p; i > 0; i--)
            {
                wynik *= n;
                p--;
            }
            Console.WriteLine("Wynik: "+wynik);
            Console.ReadLine();

        }
    }
}
