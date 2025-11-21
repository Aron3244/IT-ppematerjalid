namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int i = 1;

            do
            {
                Console.WriteLine(i);
                //suurendab numbrit ühe võrra ehk number +1
                i++;
                //kui number on väiksem või võrdne viiega siis jätkab tsüklit
            } while (i <= 5);
        }
    }
}
