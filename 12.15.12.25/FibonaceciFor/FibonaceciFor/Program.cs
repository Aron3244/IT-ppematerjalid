using System.Collections.Generic;

namespace FibonaceciFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("N`ita esimest Fibonacci seeriat");
            Console.WriteLine("-------------------------------\n\n");
            Console.WriteLine("Sisesta number");
            int prv = 0, pre = 1, trm, i, n;
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Siin on Fibonacci seeria {0} kuni \n", n);
            Console.Write($"{0} {1}", prv, pre);

            for (i  = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("{0} ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }
}
