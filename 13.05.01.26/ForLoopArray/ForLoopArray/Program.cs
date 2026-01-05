namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //vaja thea string array H, e, l, l,  o
            //kasutada for loopi


            string[] array = { "H", "e", "l", "l", "o", };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //kasutage nüüd foreach-i
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
