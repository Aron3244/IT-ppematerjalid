namespace Swicth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal ja vajuta enter");
            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                     Console.WriteLine("Vokaal a");
                    break;

                case "e":
                     Console.WriteLine("Vokaal a");
                    break;

                case "i":
                     Console.WriteLine("Vokaal i");
                    break;

                default:
                     Console.WriteLine("Muu täht");
                    break;
                
            }
        }
    }
}


