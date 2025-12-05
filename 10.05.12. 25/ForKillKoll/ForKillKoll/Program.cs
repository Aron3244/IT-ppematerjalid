namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Eelnevaid tedmisi kasutades programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll

            Console.WriteLine("Sisesta korduste arv");
            int arv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arv; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill - koll");
                }

                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine("killadi - koll");
                }

               
                Console.WriteLine("kill - koll");
            }
        }
    }
}
