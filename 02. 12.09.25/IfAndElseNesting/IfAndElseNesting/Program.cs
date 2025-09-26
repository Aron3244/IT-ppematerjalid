using System;

namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If and else nesting1");

            //muutuja nimega y on andmetüüp double e komakohaga arv ja väärtus on 9
            double y = 100;

            //sulgude sees olevat väärtust kontrollitakse, et kas vastab tõele või mitte
            if (y == 9)
            {
                //kui ma panen if-i sisse if-i, siis seda nimetatakse nestimiseks
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus oli 0 kuni 10 ja 12 kuni 19");
                }
            }
            else if (y == 20.5) 
            {
                Console.WriteLine("Vastus on 20,5. Teine tingimus vastab tõele");
            }
            else if(y == 30)
            {
                Console.WriteLine("Vastus on 30. Kolmas tingimus vastab tõele");
            }
            else
            {
                Console.WriteLine("Mingi kahtlane number");
            }
        }
    }
}
