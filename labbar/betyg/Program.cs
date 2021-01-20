using System;

namespace betyg
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa 0-5 0=F
            //slumpgenerator
            Random tärning = new Random();

            //kasata tärningen 
            int slumptal = tärning.Next(0, 6);
            Console.WriteLine($"Slumptal = {slumptal}");
            // skriv ut slumpade betyg

            /* switch (slumptal)
             {
                 case 0:
                     Console.WriteLine("du fick F");
                     break;
                 case 1:
                     Console.WriteLine("du fick E");
                     break;
                 case 2:
                     Console.WriteLine("du fick D");
                     break;
                 case 3:
                     Console.WriteLine("du fick C");
                     break;
                 case 4:
                     Console.WriteLine("du fick B");
                     break;
                 case 5:
                     Console.WriteLine("du fick A");
                     break;

                 default:
                     break;
             }*/
            string[] betyg = { "F", "E", "D", "C", "B", "A" };
            Console.WriteLine($"du fick {betyg[slumptal]} i slutbetyg");
        }
    }
}
