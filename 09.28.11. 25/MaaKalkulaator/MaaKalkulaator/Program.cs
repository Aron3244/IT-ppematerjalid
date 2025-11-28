namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 27.75 mm
            //Arutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutusses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            double coindiameter = 27.75;
            double EarthRadius = 637100000;
            double aroundEarth = 2 * Math.PI * EarthRadius;

            Console.WriteLine(aroundEarth);
            double howManyCoins = aroundEarth / coindiameter;

            Console.WriteLine("Kahe euriseid läheb ümber maa {0:} ",howManyCoins);

                



        }
    }
}
