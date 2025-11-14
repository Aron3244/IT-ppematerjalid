namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            //loeme kasutaja sisendit ja teisendame selle float tüübiks
            float firstNumber = float.Parse(Console.ReadLine());

            //konsool kirjutab kasutajale, et vali tehe: +, -, *, /
            Console.WriteLine("Vali tehe: +, -, *, /");
            string operation = Console.ReadLine();

            //konsool kirjutab, et sisesta teine number ja teisendame selle float tüübiks
            Console.WriteLine("Sisesta teine number");
            float secondNumber = float.Parse(Console.ReadLine());

            //teeme switch lausega tehte valiku

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Tulemus: {firstNumber + secondNumber}");
                    break;

                case "-":
                    Console.WriteLine($"Tulemus: {firstNumber - secondNumber}");
                    break;

                case "*":
                    Console.WriteLine($"Tulemus: {firstNumber * secondNumber}");
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud!");
                    }
                    else
                    {
                        Console.WriteLine($"Tulemus: {firstNumber / secondNumber}");
                    }
                    break;

                default:
                    Console.WriteLine("Tundmatu tehe!");
                    break;
            }

        }
    }
}