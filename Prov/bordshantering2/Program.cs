using System;
using System.IO;

namespace bordshantering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera varibler och initialisera
            int antalBord = 8;
            string filnamn = "centralbord.csv";

            //format antal gäster, namn, nota
            string tomtBordBeskrivning = "0,Inga gäster,0";
            string[] bordsInformation; //array för att lagra bokningar
            string menyVal = "";
            string bordNamn = "";
            int svar = 0, bordNr = 0, antalGäster = 0, nota = 0;


            //Presentera programmeet för användaren
            Console.WriteLine("detta är centrealresurangens bordshanterare");

            //Finns lagringsfilen?
            if (File.Exists(filnamn))
            {
                //läs in alla rader, dvs bordsbokingar
                bordsInformation = File.ReadAllLines(filnamn);
                Console.WriteLine("inläsning lyckades(bordsbkningar)");
            }
            else
            {
                //skapa en tom bordslista i arrayen
                //lagra etta i filen
                bordsInformation = new string[antalBord];

                //fyll arrayen med tomma bord

                for (int i = 0; i < antalBord; i++)
                {
                    bordsInformation[i] = tomtBordBeskrivning;
                }

                //lagra i filen
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Fil med bordsinformation saknas, ny fil skapades");
            }
            //skriv ut huvudmenyn


            while (menyVal != "5")
            {
                Console.WriteLine("Välj alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Lägg till/ändra bordsinformation");
                Console.WriteLine("3. markera bord tomt");
                Console.WriteLine("4. Lägg till nota");
                Console.WriteLine("5. Avsluta");
                menyVal = Console.ReadLine();

                switch (menyVal)
                {
                    case "1":
                        int totaltAntalGäster = 0;
                        for (int i = 0; i < antalBord; i++)
                        {
                            if (bordsInformation[i] == tomtBordBeskrivning)
                            {
                                // border är tomt
                                Console.WriteLine($"bord {i + 1} - inga gäster");
                            }
                            else
                            {
                                //borde rhar en bokning
                                //plocka namn och antal gäster
                                string[] delar = bordsInformation[i].Split(",");
                                string antalGästerString = delar[0];
                                bordNamn = delar[1];
                                string notaString = delar[2];
                                totaltAntalGäster += int.Parse(antalGästerString);
                                Console.WriteLine($"bord {i + 1} - Namn:{bordNamn}, antal gäster:{antalGästerString}, notan:{nota}kr");

                            }
                        }

                        Console.WriteLine("totalt antal gäster = " + totaltAntalGäster);

                        break;

                    case "2":
                        //fråga bords nummer

                        Console.WriteLine("Vilket bordsnummer vill du ändra på?");
                        while (!int.TryParse(Console.ReadLine(),out svar) && svar <= 1 || svar > antalBord)
                        {
                            Console.WriteLine("fel försök igen icke giltigt");
                        }
                        bordNr = svar;

                        //fråga namn
                        Console.WriteLine("i vilket namn");
                        bordNamn = Console.ReadLine();

                        //fråga antal gäster
                        Console.WriteLine("hur många gäster är det");
                         while (!int.TryParse(Console.ReadLine(),out svar) && svar <= 1)
                        {
                        Console.WriteLine("fel försök igen icke giltigt");
                        }
                        antalGäster = svar;
                        //vad händer om man mater fel antal gäster

                        //spara i arrayn
                        bordsInformation[bordNr - 1] = $"{antalGäster},{bordNamn}";
                        //spara i filen
                        File.WriteAllLines(filnamn, bordsInformation);

                        break;

                    case "3":

                        //fråga bords nummer

                       Console.WriteLine("Vilket bordsnummer vill du ändra på?");
                        while (!int.TryParse(Console.ReadLine(),out svar) && svar <= 1 || svar > antalBord)
                        {
                            Console.WriteLine("fel försök igen icke giltigt");
                        }
                        bordNr = svar;

                        //spara i arrayn
                        bordsInformation[bordNr - 1] = tomtBordBeskrivning;
                        //spara i filen
                        File.WriteAllLines(filnamn, bordsInformation);

                        break;

                    case "4":
                    Console.WriteLine("Vilket bordsnummer vill du ändra på?");
                        while (!int.TryParse(Console.ReadLine(),out svar) && svar <= 1 || svar > antalBord)
                        {
                            Console.WriteLine("fel försök igen icke giltigt");
                        }
                        bordNr = svar;

                        //fråga antal gäster
                        Console.WriteLine("hur mycket nota");
                         while (!int.TryParse(Console.ReadLine(),out svar) && svar <= 1)
                        {
                        Console.WriteLine("fel försök igen icke giltigt");
                        }
                        nota = svar;
                        //vad händer om man mater fel antal gäster

                        //spara i arrayn
                        bordsInformation[bordNr - 1] = $"{antalGäster},{bordNamn},{nota}";
                        //spara i filen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;

                    case "5":
                    break;

                    default:
                        Console.WriteLine("du valde inte ett giltigt alternativ");

                        break;
                }
            }
        }
    }
}
