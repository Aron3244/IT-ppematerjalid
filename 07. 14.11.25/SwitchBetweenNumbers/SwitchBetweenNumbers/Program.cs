internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sisesta koondtulemus");
        //esimee koondtulemuse puhul on number vahemikus
        //0 kuni 100
        //Teise puhul 101 kuni 200 ja
        //kolmanda puhul 201 kuni 300
        //kasuta switchi



        string number = Console.ReadLine();
        int number2 = int.Parse(number);

        switch (number2)
        {
            case >= 0 and <= 100:
                Console.WriteLine("Esimene vahemik");
                break;

            case >= 101 and <= 200:
                Console.WriteLine("Teine vahemik");
                break;

            case >= 201 and <= 300:
                Console.WriteLine("Kolmas vahemik");
                break;

            default:
                Console.WriteLine("Väärtus ei sobi vahemikku");
                break;
        }
    }
}