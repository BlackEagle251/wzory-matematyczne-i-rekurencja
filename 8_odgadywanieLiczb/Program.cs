using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_odgadywanieLiczb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz liczbę z przedziału 1-20.");

            int dolnaGranica = 1;
            int gornaGranica = 20;
            int zgadnij = (dolnaGranica + gornaGranica) / 2;
            bool poprawnie = false;

            while (!poprawnie)
            {
                Console.WriteLine($"Czy twoja liczba to {zgadnij}? Odpowiedz liczbą ujemną, dodatnią lub zerem");
                
                int odpowiedz = int.Parse(Console.ReadLine());

                if (odpowiedz < 0)
                {
                    gornaGranica = zgadnij - 1;
                    zgadnij = (dolnaGranica + gornaGranica) / 2;
                }
                else if (odpowiedz > 0)
                {
                    dolnaGranica = zgadnij + 1;
                    zgadnij = (dolnaGranica + gornaGranica) / 2;
                }
                else
                {
                    poprawnie = true;
                }
            }
            

            

            Console.WriteLine($"Odgadłem! Twoja liczba to {zgadnij}");
            Console.ReadLine();
        }
        
    }
}
