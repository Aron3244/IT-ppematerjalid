namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            Console.Title = "Digital Clock";
            //while (true)
            //{
            //    Console.Clear();
            //   Console.WriteLine("Digital Clock\n");
            //     Console.WriteLine(DateTime.Now.ToString("HH:mm_ss"));
            //    Thread.Sleep(1000);
            // }
            //tsükkel
            //while (true)
            //{
            //Puhastab konsooli akna
            // Console.Clear(); 
            //muutuja, millel on arvui aeg
            // string time = DateTime.Now.ToString("HH:mm:ss");
            //Viib kella laiuselt keskele
            // int x = (Console.WindowWidth - time.Length) / 2;
            //Viib kella kõtguselt  keskele
            //  int y = Console.WindowHeight / 2;
            //Kella numbrite näitemise koht
            // Console.SetCursorPosition(x, y);
            //näitab aega läbi muutuja time
            //  Console.WriteLine(time);
            //Muutab aega iga sekund
            //  Thread.Sleep(1000);

            //}

            //for loopiga thea digitaalne kell


            for ( ; ;)
                {
                    string time = DateTime.Now.ToString("HH:mm:ss");

                    int x = (Console.WindowWidth - time.Length) / 2;
                    int y = Console.WindowHeight / 2;

                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(time);

                    Thread.Sleep(1000);
                }
            }
        }
    }


