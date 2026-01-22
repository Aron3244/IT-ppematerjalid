using System;
using System.IO;
using System.Threading;

// namespace – projekti loogiline nimi
namespace LoputooIKT
{
    // class – programm asub klassi sees
    class Program
    {
        // Main – programmi alguspunkt
        static void Main(string[] args)
        {
            // bool – loogiline andmetüüp (true / false)
            

            // do-while tsükkel – menüü töötab kuni kasutaja väljub
            
                Console.Clear();
                Console.WriteLine("===== LÕPUTÖÖ MENÜÜ =====");
                Console.WriteLine("1 - Andmetüübid ja ReadLine");
                Console.WriteLine("2 - If / Else ja meetodid");
                Console.WriteLine("3 - Tsüklid (for, while, foreach)");
                Console.WriteLine("4 - Kalkulaator (iga tehe meetodis)");
                Console.WriteLine("5 - Geomeetrilised kujundid");
                Console.WriteLine("6 - Ruutvõrrand");
                Console.WriteLine("7 - Digitaalne kell");
                Console.WriteLine("8 - Failidega töötamine");
                Console.WriteLine("0 - Välju");
                Console.Write("Valik: ");

                // string – kasutaja sisestus on alati string
                string choice = Console.ReadLine();

                // switch – valiku tegemine
                switch (choice)
                {
                    case "1": Andmetuubid(); break;
                    case "2": IfElseMeetodid(); break;
                    case "3": Tsuklid(); break;
                    case "4": Kalkulaator(); break;
                    case "5": Kujundid(); break;
                    case "6": Ruutvorrand(); break;
                    case "7": DigitaalneKell(); break;
                    case "8": Failid(); break;
                    default:
                        Console.WriteLine("Vale valik!");
                        Console.ReadKey();
                        break;
                }
            
            
        }

        // ================= ANDMETÜÜBID =================
        static void Andmetuubid()
        {
            Console.Clear();

            // string – tekst
            Console.Write("Sisesta nimi: ");
            string nimi = Console.ReadLine();

            // int – täisarv
            Console.Write("Sisesta vanus: ");
            int vanus = Convert.ToInt32(Console.ReadLine());

            // double – komakohaga arv
            Console.Write("Sisesta pikkus (m): ");
            double pikkus = Convert.ToDouble(Console.ReadLine());

            // bool – loogiline väärtus
            bool taiseline = vanus >= 18;

            Console.WriteLine("\n--- TULEMUS ---");
            Console.WriteLine("Nimi (string): " + nimi);
            Console.WriteLine("Vanus (int): " + vanus);
            Console.WriteLine("Pikkus (double): " + pikkus);
            Console.WriteLine("Täisealine (bool): " + taiseline);

            Console.ReadKey();
        }

        // ================= IF / ELSE + MEETODID =================
        static void IfElseMeetodid()
        {
            Console.Clear();
            Console.WriteLine("1 - For loop (3 korda tekst)");
            Console.WriteLine("2 - While loop (3 korda tekst)");
            Console.WriteLine("3 - Kahe arvu liitmine");
            Console.WriteLine("4 - Vanuse kuvamine");
            Console.Write("Valik: ");

            string v = Console.ReadLine();

            if (v == "1")
            {
                for (int i = 0; i < 3; i++)
                    Console.WriteLine("For loop töötab");
            }
            else if (v == "2")
            {
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("While loop töötab");
                    i++;
                }
            }
            else if (v == "3")
            {
                Console.Write("Arv 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Arv 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Summa: " + (a + b));
            }
            else if (v == "4")
            {
                Console.Write("Sisesta vanus: ");
                int vanus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sinu vanus on: " + vanus);
            }

            Console.ReadKey();
        }

        // ================= TSÜKLID =================
        static void Tsuklid()
        {
            Console.Clear();

            // for – korrutustabel
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("5 x " + i + " = " + (5 * i));

            // foreach – massiivi läbimine
            string[] nimed = { "Mari", "Juku", "Kati" };
            foreach (string n in nimed)
                Console.WriteLine(n);

            // while nesting – tsükkel tsükli sees
            int x = 0;
            while (x < 3)
            {
                int y = 0;
                while (y < 3)
                {
                    Console.Write("* ");
                    y++;
                }
                Console.WriteLine();
                x++;
            }

            Console.ReadKey();
        }

        // ================= KALKULAATOR =================
        static void Kalkulaator()
        {
            Console.Clear();
            Console.WriteLine("1 - Liitmine");
            Console.WriteLine("2 - Lahutamine");
            Console.WriteLine("3 - Korrutamine");
            Console.WriteLine("4 - Jagamine");
            Console.Write("Valik: ");

            string v = Console.ReadLine();

            switch (v)
            {
                case "1": Liitmine(); break;
                case "2": Lahutamine(); break;
                case "3": Korrutamine(); break;
                case "4": Jagamine(); break;
            }
        }

        static void Liitmine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a + b));
            Console.ReadKey();
        }

        static void Lahutamine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a - b));
            Console.ReadKey();
        }

        static void Korrutamine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tulemus: " + (a * b));
            Console.ReadKey();
        }

        static void Jagamine()
        {
            Console.Write("Arv 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arv 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b != 0)
                Console.WriteLine("Tulemus: " + (a / b));
            else
                Console.WriteLine("Nulliga jagada ei saa");

            Console.ReadKey();
        }

        // ================= KUJUNDID =================
        static void Kujundid()
        {
            Console.Clear();
            Console.WriteLine("1 - Ruut");
            Console.WriteLine("2 - Ristkülik");
            Console.WriteLine("3 - Ring");
            Console.Write("Valik: ");

            string v = Console.ReadLine();

            if (v == "1")
            {
                Console.Write("Külg: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pindala: " + (a * a));
                Console.WriteLine("Ümbermõõt: " + (4 * a));
            }
            else if (v == "2")
            {
                Console.Write("Laius: ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.Write("Pikkus: ");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pindala: " + (l * p));
                Console.WriteLine("Ümbermõõt: " + (2 * (l + p)));
            }
            else if (v == "3")
            {
                Console.Write("Raadius: ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pindala: " + Math.PI * r * r);
                Console.WriteLine("Ümbermõõt: " + (2 * Math.PI * r));
            }

            Console.ReadKey();
        }

        // ================= RUUTVÕRRAND =================
        static void Ruutvorrand()
        {
            Console.Clear();
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d > 0)
                Console.WriteLine("Kaks lahendit");
            else if (d == 0)
                Console.WriteLine("Üks lahend");
            else
                Console.WriteLine("Lahendid puuduvad");

            Console.ReadKey();
        }

        // ================= DIGITAALNE KELL =================
        static void DigitaalneKell()
        {
            int i = 0;
            while (i < 5)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                i++;
            }
        }

        // ================= FAILID =================
        static void Failid()
        {
            Console.Clear();

            string path = "loputoo.txt";

            // faili loomine ja kirjutamine
            File.WriteAllText(path, "Lõputöö fail\nC# programmeerimine");

            // faili lugemine
            string[] read = File.ReadAllLines(path);
            foreach (string r in read)
            {
                Console.WriteLine(r);
                Console.WriteLine("Tähti reas: " + r.Length);
            }

            Console.ReadKey();
        }
    }
}
