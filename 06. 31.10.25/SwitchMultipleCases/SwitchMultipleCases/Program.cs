namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //sisestad konsooli väärtuse
            //loeb sisestatud väärtuse stringina
            //esimese cases on väärtus "Intro to C#", "Variables",
            //"Data Types" ja vastuseks Basic
            //teises cases on väärtus "OOP", "Classes"
            //"Objects ja vastuseks Intermediate
            //kolmandas cases on väärtus "Asynchronous Programming", "LINQ",
            //"Delegates" ja vastuseks Advanced
           
                Console.WriteLine("Sisesta teema nimi:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Intro to C#" or "Variables" or "Variables":
                        Console.WriteLine("Basic");
                        break;
                    
                    case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("Intermediate");
                        break;

                    case "Asynchronous Programming" or "LINQ" or "Delegates":
                        Console.WriteLine("Advanced");
                        break;

                    default:
                        Console.WriteLine("Tundmatu tase");
                        break;
                }
            }
        }
    }


