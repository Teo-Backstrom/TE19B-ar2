using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera en variabel för namnet
            string namn = "";
            string hobby = "";
            string medelande = "";

            // läas in namnet
            Console.Write("Ditt namn tack! ");
            namn = Console.ReadLine();
            Console.Write("Vad är din hobby?! (SVARA BARA MED ETT ORD ANNARS FUCKAR DU UPP ALLT!!) ");
            hobby = Console.ReadLine();
            //sätter samman ett medelande
            medelande = "Hej! " + namn + ". Din hobby är " + hobby + ".";

            //skriver ut medelandet
            Console.Write(medelande);


            // Console.WriteLine("Hej! " + namn + " Min hobby är " + hobby + ".");
        }
    }
}
