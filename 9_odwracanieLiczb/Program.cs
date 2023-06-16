using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_odwracanieLiczb
{
    class Program
    {
        static int odwracanieCyfer(int cyfra)
        {
            int odwroconaCyfra = 0;

            while (cyfra > 0)
            {
                int ostatniaCyfra = cyfra % 10;
                odwroconaCyfra = (odwroconaCyfra * 10) + ostatniaCyfra;
                cyfra /= 10;

            }

            return odwroconaCyfra;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int cyfra = int.Parse(Console.ReadLine());

            int odwroconaCyfra = odwracanieCyfer(cyfra);

            Console.WriteLine($"Odwrócona liczba: {odwroconaCyfra}");
            Console.ReadLine();
        }
    }
}
