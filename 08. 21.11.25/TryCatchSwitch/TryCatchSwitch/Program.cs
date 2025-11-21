namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try catch Switch");

            //tee switch, kus on ainult kaks casei 
            //ja valikud on 1 ja 2
            //defualt haru ei ole vajalik
            try
            {

            

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Sisestasid ühe");
                    break;
                    
                case 2:
                    Console.WriteLine("Sisestasid kahe");
                    break;
            }
        }
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number!");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Sisestatud number on liiga suur või liiga väike!");
            }

        }
    }
}
