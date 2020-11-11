using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklara variabler

            string val = "";
            int Tal1 = 0;
            int Tal2 = 0;
            int Tal11 = 0;
            int Tal22 = 0;

            //Presentera en meny som visas tills användare säger stopp

            while (val != "3")
            {
                //presentara en meny
                Console.WriteLine("Detta är startsidan");
                Console.WriteLine("Välj något av förljaande fal");
                Console.WriteLine("För att multiplicera två tal tryck 1");
                Console.WriteLine("För att addera två tal tryck 2");
                Console.WriteLine("För att stänga ned så tryck på 3 sen enter");

                // Läs in användrens val
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Lägg in två tal");
                        Tal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nästa tal");
                        Tal2 = int.Parse(Console.ReadLine());
                        int utmatning = Tal1 * Tal2;
                        Console.WriteLine(utmatning);
                        break;

                    case "2":
                        Console.WriteLine("Lägg in två tal");
                        Tal11 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nästa tal");
                        Tal22 = int.Parse(Console.ReadLine());
                        int utmatning2 = Tal11 + Tal22;
                        Console.WriteLine(utmatning2);
                        break;

                    case "3":
                        Console.WriteLine("Tack för idag Hejdå");
                        break;
                    //om inget stämmer
                    default:
                        Console.WriteLine("Förstår inte vad du menar försök igen");
                        break;
                }
            }


        }
    }
}
