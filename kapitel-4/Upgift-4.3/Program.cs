using System;

namespace Upgift_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklara variabler

            string val = "";
            double Tal1 = 0;
            double Tal2 = 0;

            //Presentera en meny som visas tills användare säger stopp

            while (val != "3")
            {
                //presentara en meny
                Console.WriteLine("Detta är startsidan");
                Console.WriteLine("Välj något av förljaande val");
                Console.WriteLine("För att omvandla meter till kilometer tryck 1");
                Console.WriteLine("För att omvandla kilometer till meter tryck 2");
                Console.WriteLine("För att stänga ned så tryck på 3 sen enter");

                // Läs in användrens val
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Hur många meter vill du omvanlda till kilometer");
                        Tal1 = double.Parse(Console.ReadLine());
                        Tal1 = Tal1 / 1000;
                        Console.WriteLine(Tal1 + " Kilometer");
                        break;

                    case "2":
                        Console.WriteLine("hur många kilometer vill du omvanlda till meter");
                        Tal2 = double.Parse(Console.ReadLine());
                        Tal2 = Tal2 * 1000;
                        Console.WriteLine(Tal2 + " Meter");
                        break;

                    case "3":
                        Console.WriteLine("Tack för idag Hejdå");
                        break;

                    default:
                        Console.WriteLine("Förstår inte vad du menar försök igen");
                        break;
                }
            }


        }
    }
}
