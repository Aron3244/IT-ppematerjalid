namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ushort i = 0;
            

            //kui on 10 rida konsoolis, siis lõpetab ära

            for (; ; )
            {
                Console.WriteLine("i väärtus on " + i);
                i++;

                if (i > 10)
                {
                   break;
                }
                
                
                   
            }
        }
    }
}
