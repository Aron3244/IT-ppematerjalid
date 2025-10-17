using System.Drawing;

namespace SwitchColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada switchi
            //kuvab iga kord suvalised v'rvid
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli
            Color color = (Color)(new Random()).Next(0, 5);

            switch (color)
            {
                case Color.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Red");
                    break;
                case Color.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Green");
                    break;
                case Color.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Blue");
                    break;
                case Color.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("White");
                    break;
                case Color.Orange:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Orange");
                    break;
                default:
                    break;
            }
        }

        public enum Color
        {
            Red,
            Green,
            Blue,
            White,
            Orange
        }
    }
}
