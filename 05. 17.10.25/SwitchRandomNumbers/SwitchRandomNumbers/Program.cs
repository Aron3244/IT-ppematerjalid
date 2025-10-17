using System;

namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("genereerib numbreid ühest kuni kuueni");

            //Kõik kuus numbrit ära tuleb käsitleda swichiga

            int cube = new Random().Next(1, 7);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Tuli 1");
                    break;
                case 2:
                    Console.WriteLine("Tuli 2");
                    break;
                case 3:
                    Console.WriteLine("Tuli 3");
                    break;
                case 4:
                    Console.WriteLine("Tuli 4");
                    break;
                case 5:
                    Console.WriteLine("Tuli 5");
                    break;
                case 6:
                    Console.WriteLine("Tuli 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}