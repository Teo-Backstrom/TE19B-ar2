using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            while (svar != "4")
            {

                VisaMeny();
                svar = Console.ReadLine();

                switch (svar)
                {
                    case "1":
                        Addera();
                        break;
                    case "2":
                        Subtrahera();
                        break;
                    case "3":
                        Mulitpisera();
                        break;
                    case "4":
                        Console.WriteLine("Hej då");
                        break;
                    default:
                        Console.WriteLine("Ej giltigt försök igen");
                        break;
                }
            }
        }
        static void VisaMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1.Addera 2 tal");
            Console.WriteLine("1.Subtrahera 2 tal");
            Console.WriteLine("3. Mulitpisera 2 tal");
            Console.WriteLine("4. Avsluta");
        }

        static void Addera()
        {
            Console.WriteLine("Välja 2 tal du vill addera");
            Console.WriteLine("Första talet");
            int x = TryParse();
            Console.WriteLine("andra talet");
            int y = TryParse();

            int summa = x + y;
            Console.WriteLine($"summan av talen är {summa}");
        }

        static void Subtrahera()
        {
            int svar = 0;
            Console.WriteLine("Välja 2 tal du vill subtrahera");
            Console.WriteLine("Första talet");
            while (!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("fel försök igen icke giltigt");
            }
            int x = svar;
            Console.WriteLine("andra talet");
            while (!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("fel försök igen icke giltigt");
            }
            int y = svar;

            int skilnad = x + y;
            Console.WriteLine($"Skilnaden av talen är {skilnad}");
        }
        static void Mulitpisera()
        {
            int svar = 0;
            Console.WriteLine("Välja 2 tal du vill Mulitplisera");
            Console.WriteLine("Första talet");

            int x = svar;
            Console.WriteLine("andra talet");
            while (!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("fel försök igen icke giltigt");
            }
            int y = svar;

            int produkt = x + y;
            Console.WriteLine($"Produkten av talen är {produkt}");
        }

        static int TryParse()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("fel försök igen icke giltigt");
            }
            return svar;
        }

    }
}
