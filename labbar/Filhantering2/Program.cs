using System;
using System.IO;

namespace Filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            //filnamnet
            string filnamn = "./animals.txt";

            // Läs in alla rader
            string[] rader = File.ReadAllLines(filnamn);

            //läs in sökterm
            Console.WriteLine("ange sökterm ( första bokstav): ");
            string sökterm = Console.ReadLine();

            //loopa igenom arrayen
            int counter = 1;
            foreach (var rad in rader)
            {
                if (rad.Substring(0, 1) == sökterm)
                {
                    Console.WriteLine(counter + " " + rad);
                    counter++;
                }

            }

            Console.WriteLine($"hittade {counter - 1} djur");
        }
    }
}
