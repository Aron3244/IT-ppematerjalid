namespace HindelineTöö1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta üks valikutsest");
            Console.WriteLine("püramiid");
            Console.WriteLine("ristkülik");
            Console.WriteLine("ruutvõrrand");
            string vehicleType = Console.ReadLine().ToLower();

            switch (vehicleType)
            {
                case "püramiid":
                    püramiidi();
                    break;

                case "ristkülik":
                    ristkülik();
                    break;

                case "ruutvõrrand":
                    ruutvõrrand();
                    break;

                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }

        static void püramiidi()
        {
            Console.WriteLine("Sisesta tagurpidi püramiidi kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

           for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");  

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n"); 
                }
        }

        static void ristkülik()
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
                Console.WriteLine(" ");
            }
        }

        static void ruutvõrrand()
        {
            Console.WriteLine("Sisesta a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta c");
            double c = double.Parse(Console.ReadLine());

            double vastus = b * b - 4 * a * c;
            Console.WriteLine(
            $"x1 = {(-b + Math.Sqrt(vastus)) / (2 * a)}, " +
            $"x2 = {(-b - Math.Sqrt(vastus)) / (2 * a)}"
        );

        }
    }
}

