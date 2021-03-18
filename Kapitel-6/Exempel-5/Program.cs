using System;

namespace Exempel_5
{
    class Program
    {
        //EN klass variabel
        static string respons = "Du skrev inte ett heltal, vg förösk igen";

        //Ett bra exempel på klassvariael
        static Random slump = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Metoden för sökert sätt att läsa heltal
        /// </summary>
        /// <returns>Heltalet</returns>
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine(respons);
            }
            return heltal;
        }
    }
}

