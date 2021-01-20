using System;
using System.IO;

namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriva till en textfil
            File.WriteAllText("fil1.txt", "Nu snöar det igen! kul!");

            //läsa innehållet av en textfil

            string allText = File.ReadAllText("./Filhantering.csproj");


            //Skriv ut innehållet
            Console.WriteLine($"Innehållet: \n{allText}");

            //Fråg användaren om filnamn
            Console.WriteLine("Ange filnamn: ");
            string filnamn = Console.ReadLine();
            //kontrolera att filen finns
            if (File.Exists(filnamn))
            {
                string texten = File.ReadAllText(filnamn);
                Console.WriteLine(texten);
            }
            else
            {
                Console.WriteLine($"hittade inte filen: {filnamn}");
            }
        }
    }
}
