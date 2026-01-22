using System.Data;
using System.Drawing;
using System.Net.Http.Headers;

namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vigade parandus");


            Console.WriteLine("Vajuta numbrit");
            Console.WriteLine("1. Tagurpidi Püramiid");
            Console.WriteLine("2. Ristkülik");
            Console.WriteLine("3. Püramiid");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    //meetodi välja kutsumine
                    UpSideDownPyramiid();
                    break;

                case "2":
                    Rectangle();
                    break;

                case "3":
                    Pyramiit();
                    break;

                default:
                    Console.WriteLine("Sellist valikud ei ole");
                    break;
            }
        }

        static void UpSideDownPyramiid()
        {
            Console.WriteLine("Sisesta kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n - 0; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - j; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
        static void Rectangle()
        {
            Console.WriteLine("Sisesta ristküliku kõrgus");
            int kõrgus = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta ristküliku laius");
            int laius = int.Parse(Console.ReadLine());

            for (int i = 0; i < kõrgus; i++)
            {
                for (int j = 0; j < laius; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(" ");
            int area = kõrgus * laius;

            int aronud = 2 * (laius + kõrgus);

            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + aronud);

        }
        static void Pyramiit()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Sisesta püramiidu kõrus");

            int i, j, n;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}
