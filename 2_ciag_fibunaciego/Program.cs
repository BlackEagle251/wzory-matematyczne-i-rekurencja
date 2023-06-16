using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ciag_fibunaciego
{
    class Program
    {
        static void Fibonacci(int n)
        {

            int a = 0;
            int b = 1;

            Console.WriteLine("Ciąg Fibonacciego");
            Console.Write($" {a} {b}");

            for(int i = 2; i < n; i++)
            {
                int kolejny = a + b;
                Console.Write($" {kolejny}");

                a = b;
                b = kolejny;
            }
            Console.WriteLine();
            Console.ReadLine();


        }

        static void Main(string[] args)
        {
            int n = 10; // liczba kolejnych wyrazów do wypisania
            Fibonacci(n);
        }
    }
}
