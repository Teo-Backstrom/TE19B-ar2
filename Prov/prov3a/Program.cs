using System;

namespace prov3a
{
    class Program
    {
        static void Main(string[] args)
        {

            //deklarerar varibaler
            string planet = "";
            double nyÅlder = 0;
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            //berättar vad programmet gör
            Console.WriteLine("Program som räknar ut din ålder på en annan planet.");

            //frågrar ålder på användaren
            Console.WriteLine("Hur gammal är du");
            //läser in användarens ålder
            double ålder = ReadDouble();

            //deklarerar menyVal
            string menyVal = "0";
            //loopar programet tills användaren väljer 8
            while (menyVal != "8")
            {
                //sätter background till grå
                Console.BackgroundColor = ConsoleColor.DarkGray;

                //läser in menyValet och skriver ut Meny alternativ
                menyVal = SkrivMeny();

                //switchar på menyVal och räknar ut den nya ålder och skriver ut den tll användaren
                switch (menyVal)
                {
                    case "1":
                        nyÅlder = ålder / 0.2408467;
                        planet = "Merkurius";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    case "2":
                        nyÅlder = ålder / 0.61519726;
                        planet = "Venus";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    case "3":
                        nyÅlder = ålder / 1.8808158;
                        planet = "Mars";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    case "4":
                        nyÅlder = ålder / 11.862615;
                        planet = "Jupiter";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    case "5":
                        nyÅlder = ålder / 29.447498;
                        planet = "Saturnus";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    case "6":
                        nyÅlder = ålder / 84.016846;
                        planet = "Uranus";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    case "7":
                        nyÅlder = ålder / 164.79132;
                        planet = "Neptunus";
                        SkrivSvar(planet, nyÅlder);
                        break;
                    //hejdå fras
                    case "8":
                        Console.WriteLine("Välkomen åter");
                        break;

                    //error messege på menyval
                    default:
                        Console.WriteLine("du skrev in något ogitigt försök igen");
                        break;

                }

            }


        }

        /// <summary>
        /// Skriver ut menyvalen och läser in användarens val
        /// </summary>
        /// <returns>användarens menyval</returns>
        static string SkrivMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Räkna ut ålder på Merkurius");
            Console.WriteLine("2. Räkna ut ålder på Venus");
            Console.WriteLine("3. Räkna ut ålder på Mars");
            Console.WriteLine("4. Räkna ut ålder på Jupiter");
            Console.WriteLine("5. Räkna ut ålder på Saturnus");
            Console.WriteLine("6. Räkna ut ålder på Uranus");
            Console.WriteLine("7. Räkna ut ålder på Neptunus");
            Console.WriteLine("8. Avluta");
            string svar = Console.ReadLine();
            return svar;
        }

        /// <summary>
        /// skriver ut användaens ålder på vilken planet
        /// </summary>
        /// <param name="planet">vilken planet som åldern är uträknad på</param>
        /// <param name="nyÅlder">den ny åldern på en viss planet</param>
        static void SkrivSvar(string planet, double nyÅlder)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"På {planet} är du {nyÅlder} år");
        }

        /// <summary>
        /// läser in en string och gör om till double
        /// </summary>
        /// <returns>åldern i double format</returns>
        static double ReadDouble()
        {

            double svar;
            while (!double.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("Du skrev inte in ett tal. Försök igen.");
            }
            return svar;
        }



    }
}
