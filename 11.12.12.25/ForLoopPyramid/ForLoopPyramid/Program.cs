using System;

namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk e poolik püramiid");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Sisesta suurus: ");
            int i, j, n;  // Declaration of variables i, j, and r as integers

            
            n = Convert.ToInt32(Console.ReadLine());  


            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");  

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n");  
            }

            
            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");  

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n"); 
            }
        }
    }
}

