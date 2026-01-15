namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali kujund:");
            Console.WriteLine("1 - Ristkülik");
            Console.WriteLine("2 - Kolmnurk");
            Console.WriteLine("3 - Ring");
            Console.WriteLine("4 - Ruutvõrrand");

            int valik = int.Parse(Console.ReadLine());

            if (valik == 1)
            {
                Ristkylik();
            }
            else if (valik == 2)
            {
                Kolmnurk();
            }
            else if(valik == 3)
            {
                Ring();
            }
            else if (valik == 4)
            {
                Ruutvõrrand();
            }
            else
            {
                Console.WriteLine("Vale valik!");
            }
        }

        static void Ristkylik()
        {
            Console.WriteLine("Sisesta ristküliku kõrgus:");
            int kõrgus = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta ristküliku laius:");
            int laius = int.Parse(Console.ReadLine());

            // Joonistamine
            for (int i = 0; i < kõrgus; i++)
            {
                for (int j = 0; j < laius; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }

            int pindala = kõrgus * laius;
            int ymbermoot = 2 * (kõrgus + laius);

            Console.WriteLine("\nRistküliku pindala: " + pindala);
            Console.WriteLine("Ristküliku ümbermõõt: " + ymbermoot);
        }

        static void Kolmnurk()
        {
            Console.WriteLine("Sisesta kolmnurga suurus:");
            int suurus = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= suurus; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }
        }
        static void Ring()
        {
            Console.WriteLine("Sisesta ringi raadius:");
            double r = double.Parse(Console.ReadLine());

            double pi = 3.14;
            double area = pi * r * r;
            double around = 2 * pi * r;

            Console.WriteLine("\nRingi pindala: " + area);
            Console.WriteLine("Ringi ümbermõõt: " + around);
        }

        static void Ruutvõrrand()
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
