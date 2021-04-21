using System;

namespace Exempel_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en taxt att kryptera:");
            string meddelande = Console.ReadLine();

            Console.WriteLine($"Krypterat:{CeasarKryptera(meddelande)}");
            Console.WriteLine($"Krypterat:{CeasarKryptera(meddelande, 3)}");
        }

        /// <summary>
        /// Krypterar den text med CesarKrypto-metoden
        /// </summary>
        /// <param name="text">texten som ska krypteras</param>
        /// <param name="nyckel">Valbara. antal steg som skiftas i teckentabellen</param>
        /// <returns></returns>
        static string CeasarKryptera(string text, int nyckel = 1)
        {
            string textKrypterad = "";
            //loopa igenom texten bokstav för bokstav
            for (int i = 0; i < text.Length; i++)
            {
                // plocka ut ett tecken
                char tecken = text[i];

                //ta reda på teckencodenen(unicode)

                int teckenKod = (int)tecken;

                //Räkna ut krypterat tecken

                int teckenKodKrypterat = teckenKod + nyckel;

                //tillbaka till tecken (unicode)
                char teckenKrypterat = (char)teckenKodKrypterat;

                //sätt samman krypterat text
                textKrypterad += teckenKrypterat;
            }
            return textKrypterad;
        }
    }
}
