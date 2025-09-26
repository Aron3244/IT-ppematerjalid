namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere, World!");

            //bool andmetüüp toetab ainult true ja false
            bool check = true;
            bool negative = false;

            //string
            //string on tähemärk
            //kõike saab sisestada, mis on klaviatuuril
            string mark = "123ldfjnoehrgliu827638734¤&/()()(=)(ÄÖÜ";
            string mark2 = "123";
            Console.WriteLine(mark + mark2);

            //int e täisarv
            //teha kalkulatsioon, kus muutuja täisarv liidetakse 
            //täisarv2-ga
            //tulemust peab näitama konsoolis
            int täisarv = 123;
            int täisarv2 = 123;
            Console.WriteLine(täisarv + täisarv2);

            //byte max väärtus on 256 numbrit
            //0 käsitleb arvuti meie mõttes, kui ühte
            byte a = 255;

            //sbyte saab käsitleda nii negatiivset, kui ka 
            //positiivset väärtust 8-biti ulatuses
            sbyte b = -128;

            //char on tähemärk
            char ch = 'a';
            char numberCh = '1';
            //kui paned 5 ette (char), siis seda nimetatakse castimiseks
            char numberCh1 = (char)5;

            //decimal
            //tuleb panna numbri järgi m ja annab teada,
            //et tegemist on decimal andmetüübiga
            decimal decim = 2.1m;

            //double
            //mis on double?
            //komakohaga arv
            double doub = 12.4;

            //float
            //komakohaga arv, mis tahab numbri lõppu f-tähte
            float komakohagaArv = 4.564f;

            //long
            //mis on selle andmetüübi eripära?
            //saab negatiivset ja positiivset numbrit lisada
            //mis on long andmetüübi max väärtus?
            //9 223 372 036 854 775 807
            long longNr = -2354;

            //short
            //16 bitine arv
            short lyhikeAr = 4099;
        }
    }
}
