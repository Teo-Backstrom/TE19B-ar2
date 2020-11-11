using System;

namespace CeasarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Be om en text
            Console.WriteLine("Ange en text");
            string text = Console.ReadLine();

            // loopa igenom inmatad text bokstav för bokstav
            int textLängd = text.Length;
            Console.WriteLine($"Texten är {textLängd} lång");


            int hopp = 0;
            Console.WriteLine("Hur många steg vill du hoppa(1-9)");
            string hoppString = Console.ReadLine();

            while (!int.TryParse(hoppString, out hopp))
            {
                Console.WriteLine("Hur många steg vill du hoppa(1-9)");
                hoppString = Console.ReadLine();
            }


            string krypteradText = "";
            for (int i = 0; i < textLängd; i++)
            {
                Console.WriteLine("loop nr" + i);

                // Plocka ut bokstav på position i
                char bokstav = text[i];
                Console.WriteLine("Bokstaven på psooition " + i + " är " + bokstav);

                // ACII värde på tecknet
                int ascii = (int)bokstav;
                Console.WriteLine($"Bokstaven {bokstav} har ASCII-värdet {ascii}");

                //Ceasar kryptering
                ascii += hopp;
                //Plocka ut motsvarande tecken enligt ascii-tabellen
                char krypteradBokstav = (char)ascii;

                Console.WriteLine($"Bokstaven {bokstav} krypteras till {krypteradBokstav}");

                krypteradText += krypteradBokstav.ToString();

                Console.WriteLine($"Det krypterade meddelandet är : {krypteradText}");
            }

        }
    }
}
