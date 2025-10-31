namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta 10, 20 või 30.");
            //peab saam sisestada numbrit ja muudab selle int andmetüübiks

            //tuleb thea switch, kus on esimene case 10, teine on 20 ja kolams on 30
            //kindlasti tuleb ka defuat lõppu teha

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("Sisestasid 10");
                    break;

                case 20:
                    Console.WriteLine("Sisestasid 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid 30");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
