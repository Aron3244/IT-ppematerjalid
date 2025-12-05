namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asterisk");

            int nr = Convert.ToInt32(Console.ReadLine());

            //tuleb kasutada for loopi
            //sisestan ridade arvuja tuleb vastav ridade arn konsooli
            //pean näirama tärne

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("*");
            }
            
        }
    }
}
