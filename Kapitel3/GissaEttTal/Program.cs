using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa ett tal
            Random random = new Random();
            int slumptal = random.Next(1, 6);
            // läs in gissningen



            //fråga 5x
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("gissa et tal(1-6)");
                int gissning = int.Parse(Console.ReadLine());

                //kolla om gissningen är korrekt

                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt");
                    i = 5;
                }
                else
                {
                    Console.WriteLine("Fel");
                }
            }
        }
    }
}
