using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //slulmpa fram ett tal 1-6
            Random tarning = new Random();
            int slumptal = tarning.Next(1, 7);

            //Upprepa tills rätt svar
            while (true)
            {
                //Läs in användarens gissning
                Console.WriteLine("Gissa ett tal (1-6) ?");
                int gissning = int.Parse(Console.ReadLine());

                //Om användaren gissat rätt
                if (gissning == slumptal)
                {
                    Console.WriteLine("rätt");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel Försök igen");
                }
            }
            //Slut
            Console.WriteLine("tack för idag");
        }
    }
}
