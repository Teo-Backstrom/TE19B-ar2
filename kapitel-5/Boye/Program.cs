using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lagra dikten i en array
            int totalAntalOrd = 0;

            string[] dikt = {
                "Den mätta dagen, den är aldrig störst.",
                "Den bästa dagen är en dag av törst.",
                "Nog finns det mål och mening i vår färd -",
                "men det är vägen, som är mödan värd.",
                "Det bästa målet är en nattlång rast,",
                "där elden tänds och brödet bryts i hast.",
                "På ställen, där man sover blott en gång,",
                "blir sömnen trygg och drömmen full av sång.",
                "Bryt upp, bryt upp! Den nya dagen gryr.",
                "Oändligt är vårt stora äventyr."
            };

            //skriv ut dikten

            for (int i = 0; i < dikt.Length ; i++)
            {
                
                if (i % 2 == 0){
                    Console.WriteLine("\n");
                }
                Console.WriteLine(dikt[i]);
            }

            // räkna orden
            for (int i = 0; i < dikt.Length; i++)
            {
                string[] orden = dikt[i].Split(' ');
                int antalOrd = orden.Length;
                totalAntalOrd += antalOrd;
            }
            Console.WriteLine(totalAntalOrd);
           
        }
    }
}
