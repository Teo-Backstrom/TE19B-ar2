using System;
using System.IO;


namespace Prov2
{
    class Program
    {
        static void Main(string[] args)
        {


            string filnamn = "movies.tsv";
            // Array för att lagra bokningar
            string[] filmInformation;

            int årSök = 0;


            if (File.Exists("movies.tsv"))
            {
                filmInformation = File.ReadAllLines(filnamn);

                Console.WriteLine("programmet för att söak filmer.");

                string menyVal = "";
                while (menyVal != "3")
                {
                    // Skriv ut huvudmenyn
                    Console.WriteLine("Välj ett alternativ");
                    Console.WriteLine("1. Visa alla filmer");
                    Console.WriteLine("2. Sök år");
                    Console.WriteLine("3. Avsluta");
                    menyVal = Console.ReadLine();
                    string[] delar;

                    switch (menyVal)
                    {
                        case "1":
                            for (int i = 0; i < filmInformation.Length; i++)
                            {
                                // Bordet har en bokning
                                // Plocka ut namn och antal gäster
                                delar = filmInformation[i].Split("\t");
                                string titel = delar[0];
                                string år = delar[2];

                                // Skriv ut bokningsinfo
                                Console.WriteLine($"{i + 1}: {titel} från {år}");
                            }
                            break;

                        case "2":
                            Console.WriteLine("Vilket år söker du?");
                            while (!int.TryParse(Console.ReadLine(), out årSök) && årSök <= 1990 || årSök > 2021)
                            {
                                Console.WriteLine("fel försök igen icke giltigt");
                            }

                            int pengarSumma = 0;

                            int counter = 1;
                            foreach (var rad in filmInformation)
                            {
                                delar = rad.Split("\t");
                                string titel = delar[0];
                                string pengar = delar[1];
                                string år = delar[2];
                                string pengarUtanComma = pengar.Replace(",", "");
                                string pengarUtanDollar = pengarUtanComma.Substring(2, pengarUtanComma.Length);

                                int pengarInt = int.Parse(pengarUtanDollar);
                                if (int.Parse(år) == årSök)
                                {
                                    Console.WriteLine($"{counter}: {titel}");
                                    counter++;
                                    pengarSumma += pengarInt;
                                }

                            }
                            Console.WriteLine($"summa intäkter{pengarSumma}");

                            Console.WriteLine($"hittade {counter - 1} filmer");

                            break;

                        case "3":
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val, försök igen");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("filen movies kundeinte hittas");
            }
        }
    }
}