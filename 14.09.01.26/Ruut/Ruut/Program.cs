namespace Ruut
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //teha forl oopiga ruut
            Console.WriteLine("Sisest ruudu suurus");
            int size = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //kui suurus on sisestatud, siis kuvab meile ka ümbermõõdu ja pindala
            //\njätab ühe rea vahel
            Console.WriteLine("\n");
            int squarearea = size * size;
            int squareAround = size * 4;


            Console.WriteLine("Ruudu pindala: " + squarearea);
            Console.WriteLine("Ruudu ümbermõõt: " + squareAround);
        }
    }
}
        
    
