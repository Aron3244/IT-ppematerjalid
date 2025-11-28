namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            //tuleb kasutada while ja omakorda while while sisse panna
            //while nesting
            //while kordab enast 5 korda

            int a = 1;

            while (a <= 5) 
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + "");
                    b++;
                }

                Console.WriteLine();
                a++;

            }
        }
    }
}
      
