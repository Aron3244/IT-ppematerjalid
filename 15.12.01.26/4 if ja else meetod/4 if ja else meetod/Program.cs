using System.Threading.Channels;

namespace _4_if_ja_else_meetod

{
    internal class Program
    {

    
       
        
            static void Main(string[] args)
            {
                Console.WriteLine("Sisesta number");
            Console.WriteLine("1.ForLoop");
            Console.WriteLine("2.WhileLoop");
            Console.WriteLine("3.AddTwoNumbers");
            Console.WriteLine("4.AskAge");
            int number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    ForLoop();
                }
                else if (number == 2)
                {
                    WhileLoop();
                }
                else if (number == 3)
                {
                    AddTwoNumbers();
                }
                else if (number == 4)
                {
                    AskAge();
                }
                else
                {
                    Console.WriteLine("ei sobi");
                }
            }

            static void ForLoop()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Tere");
                }
            }

            static void WhileLoop()
            {
                int a = 0;
            do
            {
                Console.WriteLine("1");
                a++;
            }
            while (a < 3);
                   
                
            }

            static void AddTwoNumbers()
            {
                Console.WriteLine("Sisesta esimene number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Sisesta teine number");
                int num2 = int.Parse(Console.ReadLine());

                int vastus = num1 + num2;
                Console.WriteLine("Vastus on " + vastus);
            }

            static void AskAge()
            {
                Console.WriteLine("Sisesta enda vanus");
                string vanus = Console.ReadLine();
                Console.WriteLine("Sinu vanus on " + vanus);
            }
        }
    }
