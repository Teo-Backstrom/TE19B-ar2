using System;
using System.IO;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("Program för att hitta ländder med matchande sökterm");
            Console.WriteLine("Program listar land och landskod");

            // Läs in alla rader från textfilen countries.csv
            //filnamnet
            string filnamn = "./countries.csv";

            // Läs in alla rader
            string[] rader = File.ReadAllLines(filnamn);


            // Programloopen, avslutas med return




            // Fråga användare om en sökterm
            Console.WriteLine("Ange sökterm");
            string sökterm = Console.ReadLine().ToLower();


            // Sökning fungerar oavsett stora eller små bokstäver se https://krank23.gitbook.io/csharp-ref/grundlaeggande/string-manipulering



            // Avbryt programloop användaren matat in tomt dvs return




            // Loopa igenom alla rader
            int counter = 1;
            foreach (var rad in rader)
            {
                if (rad.Contains(sökterm))
                {
                    Console.WriteLine(counter + "" + rad);
                    counter++;
                }

            }

            // Dela upp raden


            // Plocka ut land


            // Plocka ut landskod


            // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/


            // Skriv ut matchande land och dess landskod


        }
    }
}

// Summering

