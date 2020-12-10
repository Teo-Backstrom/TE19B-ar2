using System;

namespace Uppgift_5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            // array med meningar
            string[] meningar = { "jag jag jga ajg", "du du du du du du d", "han han han ha n", "hon hon hon hon hon" };

            //loopar igenom med en ny rad efer varje
            foreach (string mening in meningar)
            {
                Console.WriteLine(mening);
                Console.WriteLine();
            }

        }
    }
}