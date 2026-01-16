using System.Security.Cryptography.X509Certificates;

namespace FileCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutab faili läbi konsooli");

            string filePath = "C:/Users/opilane/Desktop/WriteFile.txt";
            string input = Console.ReadLine();

            File.WriteAllText(filePath, input);
        }
    }
}
