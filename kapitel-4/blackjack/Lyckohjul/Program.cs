using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random tarning = new Random();
            int slumptal = tarning.Next(1, 10);

            Console.WriteLine("gissa ett tal mellan 1-10");
            int svar = int.Parse(Console.ReadLine());

            if (svar == slumptal)
            {
                Console.WriteLine("du vann");
            }
            else
            {
                Console.WriteLine("du förlorade");
            }
        }
    }
}
