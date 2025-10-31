namespace SwitchMetohodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta CarCoupe või truck");
            //teha switch rakendus
            //kus kasutaja sisestab sõiduki tüübi (coupe või truck)
            //ja programm kutsub vastava meetodi (CarCoupe või Truck)

            string vehicleType = Console.ReadLine().ToLower();

            switch (vehicleType)
            {
                case "CarCoupe":
                    CarCoupe();
                    break;

                case "truck":
                    Truck();
                    break;

                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }

        static void CarCoupe()
        {
            Console.WriteLine("This is a coupe car.");
        }

        static void Truck()
        {
            Console.WriteLine("This is a truck.");
        }
    }
}

