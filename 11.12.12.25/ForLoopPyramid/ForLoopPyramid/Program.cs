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

                static void Ring(string[] args)
                {
                    Console.WriteLine("Sisesta ringi raadius:");
                    double r = double.Parse(Console.ReadLine());

                    double pi = 3.14;
                    double area = pi * r * r;
                    double around = 2 * pi * r;

                    Console.WriteLine("\nRingi pindala: " + area);
                    Console.WriteLine("Ringi ümbermõõt: " + around);
                }

                static void RuutvõrrandMain(string[] args)
                {
                    Console.WriteLine("Sisesta a:");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Sisesta b:");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Sisesta c:");
                    double c = double.Parse(Console.ReadLine());

                    double D = b * b - 4 * a * c;

                    if (D > 0)
                    {
                        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        Console.WriteLine("Lahendid: x1 = " + x1 + ", x2 = " + x2);
                    }
                    else if (D == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine("Üks lahend: x = " + x);
                    }
                    else
                    {
                        Console.WriteLine("Lahendeid pole");
                    }
                }
        }
    }
}

