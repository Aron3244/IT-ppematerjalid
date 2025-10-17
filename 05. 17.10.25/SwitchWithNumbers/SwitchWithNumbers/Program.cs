using System.Diagnostics;

namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            //Teie töö on thea swich rakenduse,
            //kus on kolm case
            //Iga case puhul teeb erinevat arv beep-e
            Console.WriteLine("Sisesta number (1, 2 või 3):");
            int caseNumber = Convert.ToInt32(Console.ReadLine());
           
        
            switch (caseNumber)
            {
                case 1:
                    Console.Beep();
                    break;

                case 2:
                    Console.Beep();
                    Console.Beep();
                    break;

                case 3:
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }
    }
}