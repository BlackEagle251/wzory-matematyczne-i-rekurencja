using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_kolejneCyfry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba < 100)
            {
                Console.WriteLine("Podana musi mieć przynajmniej 3-cyfrowa");
            }
            else
            {
                Console.WriteLine("Poszczególne cyfry liczby:");

                while (liczba > 0)
                {
                    int cyfra = liczba % 10;
                    Console.WriteLine(cyfra);
                    liczba /= 10;
                }
            }
            Console.ReadLine();
        }
    }
}
