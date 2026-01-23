using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Menüü");
            Console.WriteLine("Sisesta number");
            Console.WriteLine("1.Teksti sisestus ja .txt-faili genereerimine");
            Console.WriteLine("2.Kalkulaator");
            Console.WriteLine("3.Ruut");


            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                txtFail();
            }
            else if (choice == 2)
            {
                kalkulaator();
            }
            else if (choice == 3)
            {
                Ruut();
            }
            else
            {
                Console.WriteLine("Vale valik!");
            }
        }
        static void txtFail()
        {
            Console.Clear();
            Console.WriteLine("Sisesta tekst");
            

            string filePath = "C:/Users/opilane/Desktop/Fail.txt";
            string input = Console.ReadLine();

            File.WriteAllText(filePath, input);
        }
        static void kalkulaator()
        {
            Console.Clear();
            Console.WriteLine("Vali tehe");
            Console.WriteLine("1.Litmine");
            Console.WriteLine("2.Lahutamine");
            Console.WriteLine("3.Korrutamine");
            Console.WriteLine("4.Jagamine");
            Console.WriteLine("5.Ruutvõrrand");


            string valik = Console.ReadLine();

            

            switch (valik)
            {
                case "1":
                    Liitmine();
                    break;

                    case "2":
                    Lahutamine();
                    break;

                    case "3":
                    Korrutamine();
                    break;

                    case "4":
                    Jagamine();
                    break;

                    case "5":
                    Ruutvõrrand();
                    break;

                default:
                    Console.WriteLine("Vale valik!");
                    break;
            }
        }
        static void Liitmine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a + b));
            Console.ReadKey();
        }

        static void Lahutamine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a - b));
            Console.ReadKey();
        }

        static void Korrutamine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a * b));
            Console.ReadKey();
        }

        static void Jagamine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b != 0)
                Console.WriteLine("Tulemus: " + (a / b));
            else
                Console.WriteLine("Nulliga jagada ei saa");

            Console.ReadKey();
        }
        static void Ruutvõrrand()
        {
            Console.WriteLine("Sisesta a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta c");
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
        static void Ruut()
        {
            Console.Clear();
            Console.WriteLine("Sisesta ruudu suurus");
            int suurus = int.Parse(Console.ReadLine());

            for (int i = 0; i < suurus; i++)
            {
                for (int j = 0; j < suurus; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            } 
        }
    }
}
