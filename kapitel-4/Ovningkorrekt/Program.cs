using System;

namespace Ovningkorrekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int gissning = 0;
            int gissning2 = 0;
            string gissningText = "";
            string gissningText2 = "";
            bool lyckades = false;
            bool lyckades2 = false;
            int poäng = 0;

            //ställ en fråga
            Console.WriteLine("Vad är x i formeln x * 6 = 42");

            //läs in använderes svar till det funkar
            while (lyckades == false)

            {
                gissningText = Console.ReadLine();

                // är det ett tal eller inte
                //blir det true eller false
                lyckades = int.TryParse(gissningText, out gissning);

                if (!lyckades)
                {
                    //Varnar användaren om hen inte matat in ett tal
                    Console.WriteLine("Fel! Mata in ett tal.");
                }
            }

            int produkt = gissning * 6;

            if (gissning == 7)
            {
                Console.WriteLine("Rätt svar du får ett poäng");
                poäng++;
            }

            else
            {
                Console.WriteLine("Fel svar " + gissning + " * 6 = " + produkt);
            }

            Console.WriteLine("Vad är x i formeln x * 7 = 42");

            //läs in använderes svar till det funkar
            while (lyckades2 == false)

            {
                gissningText2 = Console.ReadLine();

                // är det ett tal eller inte
                //blir det true eller false
                lyckades2 = int.TryParse(gissningText2, out gissning2);

                if (!lyckades2)
                {
                    //Varnar användaren om hen inte matat in ett tal
                    Console.WriteLine("Fel! Mata in ett tal.");
                }
            }

            int produkt2 = gissning2 * 7;

            if (gissning2 == 6)
            {
                Console.WriteLine("Rätt svar du får ett poäng");
                poäng++;
            }

            else
            {
                Console.WriteLine("Fel svar " + gissning2 + " * 7 = " + produkt2);
            }
            //kolla om gissningen ör korrekt

        }
    }
}
