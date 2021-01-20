using System;
using System.IO;

namespace Uppgift_P2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //flagga för while loop
            bool flagga = false;

            //alternativ meny
            Console.WriteLine("dina alternativ");
            Console.WriteLine("1 Skapa/skriva över en fil");
            Console.WriteLine("2 Läsa in innehållet från en fil");

            //inläsning av val
            string val = Console.ReadLine();

            // loop ifall man skriver fel filnamn
            while (!flagga)
            {
                //skriv in namn på fil
                Console.WriteLine("Skriv namnet på filen");
                string filnamn = Console.ReadLine();

                switch (val)
                {
                    case "1":

                        flagga = true;
                        Console.WriteLine("Skriv vad du vill ska komma in i filen");
                        string rad = Console.ReadLine();
                        //infogar de ovan i filnamnet man valt
                        File.WriteAllText(filnamn, rad);
                        break;

                    case "2":
                        //kollar om vilen exicterar
                        if (File.Exists(filnamn))
                        {
                            flagga = true;

                            //skriver ut innehållet
                            Console.WriteLine("Här är filens innehåll:");
                            Console.WriteLine(File.ReadAllText(filnamn));
                        }
                        else
                        {
                            //felmeddeilande får göra om
                            flagga = false;
                            Console.WriteLine("Filen finns inte!");
                        }
                        break;

                    default:
                        break;
                }
            }



        }
    }
}
