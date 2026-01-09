namespace Ruutvõrrand
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ax2 + bx + c

            // sisesta a, b ka c väärtus
            // kasutaja peab saama sisestada neid väärtuseid

            Console.WriteLine("Ruutvõrrand ax² + bx + c = 0");

            Console.Write("Sisesta a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c: ");
            double c = double.Parse(Console.ReadLine());

            double vastus = b * b - 4 * a * c;

            Console.WriteLine(
                $"x1 = {(-b + Math.Sqrt(vastus)) / (2 * a)}, " +
                $"x2 = {(-b - Math.Sqrt(vastus)) / (2 * a)}"
            );
        }
    }
}