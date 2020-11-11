using System;

namespace Ovningsprov
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            int poang = 0;
            bool lyckades = false;

            Console.WriteLine(" x * 6 = 42, Vad ska x ha för att det ska stämma");

            double produkt = x * 6;
            while (lyckades == false)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out x))
                {
                    if (x == 7)
                    {
                        Console.WriteLine("Rätt svar 7 * 6 = 42");
                        Console.WriteLine("Du har fått 1 poäng");
                        poang++;
                        lyckades = true;
                    }
                    else
                    {
                        Console.WriteLine("Fel svar " + x + " * 6 = " + produkt);
                        lyckades = true;
                    }
                }
                else
                {
                    Console.WriteLine("Svara med siffror");
                }
            }

        }
    }
}
