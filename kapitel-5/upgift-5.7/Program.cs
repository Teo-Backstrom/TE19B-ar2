using System;

namespace upgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talen = { 1, 2, 3, 4, 5 };

            int summa = 0;

            foreach (var tal in talen)
            {
                summa += tal;
            }
            Console.WriteLine(summa);
        }
    }
}
