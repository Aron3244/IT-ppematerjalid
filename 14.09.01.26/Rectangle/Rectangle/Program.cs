namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tha ristkülik tärnides
            //peab arvutama pindala ja ümbermõõdu
            Console.WriteLine("Sisesta ristküliku laius:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta ristküliku kõrgus:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height;i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            int area = width * height;
            int around = 2 * (width + height);

            Console.WriteLine("Ristküliku pindala: " + area);
            Console.WriteLine("Ristküliku ümbermõõt: " + around);
        }
    }
}

