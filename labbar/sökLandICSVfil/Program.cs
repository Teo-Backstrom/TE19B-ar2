using System;
using System.IO;

namespace sökLandICSVfil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Presenter programmet
            Console.WriteLine("Program för att hitta läder med matchande sökterm");
            Console.WriteLine("program listar land och landskod");

            //Läs in alla rader från textfilen, om den finns
            if (File.Exists("countries.csv"))
            {
                //Läser in rader
                string[] rader = File.ReadAllLines("countries.csv");

                //ber användaren om sökterm
                Console.WriteLine("ange sökterm (avsluta med retur)");
                string sökterm = Console.ReadLine();

                //loopa igenom alla rader
                foreach (var rad in rader)
                {
                    //sök i det röda fäletet

                    Console.WriteLine(rad);
                    string[] delar = rad.Split(',');

                    if (sökterm == delar[2].Substring(0, sökterm.Length))
                    {
                        Console.WriteLine(rad);
                    }

                    /* foreach (var del in delar)
                     {

                     }*/

                }
            }
            else
            {
                //felmedelnade 
                Console.WriteLine("error 404");
            }
        }
    }
}
