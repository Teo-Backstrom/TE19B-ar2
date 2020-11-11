using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random träning = new Random();
            int slumptal = träning.Next(1, 7);

            //deklarera variabel gissning
            int gissning = 0;

            //Loopar tills vi för rätt svar
            while (gissning != slumptal)
            {
                Console.WriteLine("gissa ett tal");
                //gissning = int.Parse(Console.ReadLine());

                //säkrare inmatning
                string input = Console.ReadLine();

                //Försöker översätta string till int
                if (int.TryParse(input, out gissning))
                {
                    if (gissning != slumptal)
                    {
                        Console.WriteLine("fel svar försök igen");
                    }

                }
                else
                {
                    Console.WriteLine("varför skrev du en string?");
                }


            }
            Console.WriteLine("Rätt svar");
        }

    }
}
