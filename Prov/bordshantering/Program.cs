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
            string tomtBordBeskrivning = "0,Inga gäster";
            string[] bordsInformation; //array för att lagra bokningar
            string menyVal = "";
            string antalGäster = "";
            string bordNamn = "";
            string bordNr = "";


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


            while (menyVal != "4")
            {
                Console.WriteLine("Välj alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Lägg till/ändra bordsinformation");
                Console.WriteLine("3. markera bord tomt");
                Console.WriteLine("4. Avsluta");
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
                                antalGäster = delar[0];
                                bordNamn = delar[1];
                                totaltAntalGäster += int.Parse(antalGäster);
                                Console.WriteLine($"bord {i + 1} - Namn:{bordNamn}, antal gäster:{antalGäster}");

                            }
                        }

                        Console.WriteLine("totalt antal gäster = " + totaltAntalGäster);

                        break;

                    case "2":
                        //fråga bords nummer

                        Console.WriteLine("Vilket bordsnummer vill du ändra på?");
                        while (true)
                        {
                            bordNr = Console.ReadLine();
                            //tryparse
                            if (int.Parse(bordNr) <= 0 || int.Parse(bordNr) > antalBord)
                            {
                                Console.WriteLine("fel försök igen icke giltigt");
                            }
                            else
                            {
                                break;
                            }
                        }

                        //fråga namn
                        Console.WriteLine("i vilket namn");
                        bordNamn = Console.ReadLine();

                        //fråga antal gäster
                        Console.WriteLine("hur många gäster är det");
                        antalGäster = Console.ReadLine();
                        //vad händer om man mater fel antal gäster

                        //spara i arrayn
                        bordsInformation[int.Parse(bordNr) - 1] = $"{antalGäster},{bordNamn}";
                        //spara i filen
                        File.WriteAllLines(filnamn, bordsInformation);

                        break;

                    case "3":

                        //fråga bords nummer

                        Console.WriteLine("Vilket bordsnummer vill du ändra på?");
                        while (true)
                        {
                            bordNr = Console.ReadLine();
                            //tryparse
                            if (int.Parse(bordNr) <= 0 || int.Parse(bordNr) > antalBord)
                            {
                                Console.WriteLine("fel försök igen icke giltigt");
                            }
                            else
                            {
                                break;
                            }
                        }

                        //spara i arrayn
                        bordsInformation[int.Parse(bordNr) - 1] = tomtBordBeskrivning;
                        //spara i filen
                        File.WriteAllLines(filnamn, bordsInformation);

                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("du valde inte ett giltigt alternativ");

                        break;
                }
            }
        }
    }
}
