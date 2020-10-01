using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler
            string namn = "";
            int ålder = 0;
            string medelande = "";
            int ålderÅr2025 = 0;
            float längd = 0;

            Console.WriteLine("Vad heter du");
            namn = Console.ReadLine();

            //längd i meter
            Console.WriteLine("Hur lång är du i meter");
            längd = float.Parse(Console.ReadLine());

            Console.WriteLine("Hur gammal är du");
            ålder = int.Parse(Console.ReadLine());

            ålderÅr2025 = ålder + 2025 - 2020;

            medelande = "hej du heter " + namn + " och du är " + ålderÅr2025 + " år år 2025." + "du är" + längd + "m";
            Console.WriteLine(medelande);
        }
    }
}
