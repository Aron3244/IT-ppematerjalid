namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            //loeme kasutaja sisendit ja teisendameselle float tüübiks
            float num1 = float.Parse(Console.ReadLine());

            //konsool kirjutab kasutajale, et vali tehe: +, -, *, /
            Console.WriteLine("vali tehe: +, -, *, /");
            string op = Console.ReadLine();

            //konsool kirjutab, et seisesta teine number ja teisendame selle float tüübiks
            Console.WriteLine("Sisesta teine number");
            float num2 = float.Parse(Console.ReadLine());

            //teeme switch lausega tehte valiku
            float result = 0;

           
            {
                switch (op)
                {
                    case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                        if (num2 == 0)
                            Console.WriteLine("Error");
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                }
                Console.WriteLine("Vastus on " + result);

            }
        }
    }
}