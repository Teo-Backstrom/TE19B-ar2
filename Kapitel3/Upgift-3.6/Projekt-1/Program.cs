/* ska gör en fråga sport som leder till slut till att man vinner
om man svarar alla rätt*/

using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //första fråga
            Console.WriteLine("Hur många fingrar har man på en hand? (svara med siffror)");
            int fingrar = int.Parse(Console.ReadLine());
            //om hen svarar rätt gå vidare

            string Bearnaisesås = "";
            string svar1 = "";
            string svar11 = "";
            string svar2 = "";
            string sport = "";
            int matte = 0;

            //kontrolerar svar och frgar om man vill fortsätta
            if (fingrar == 5)
            {
                Console.WriteLine("Rätt svar");
                Console.WriteLine("Vill du fortsätta eller vill du stanna här och ta hem 10$?");
                svar1 = Console.ReadLine();
                svar1 = svar1.ToLower();
            }
            //kontrolerar svar

            //kontrolerar svar och ställer fråga
            if (svar1 == "fortsätta" || svar1 == "jag vill fortsätta")
            {
                Console.WriteLine("Nästa fråga är");
                Console.WriteLine("Nämn en ingredisens i Bearnaisesås");
                Bearnaisesås = Console.ReadLine();
                Bearnaisesås = Bearnaisesås.ToLower();

                //kontrolerar svar och stälelr fråga
                if (Bearnaisesås == "smör" ||
                Bearnaisesås == "schalottenlök" ||
                Bearnaisesås == "fransk dragon" ||
                Bearnaisesås == "vitpeppar" ||
                Bearnaisesås == "rödvinsvinäger" ||
                Bearnaisesås == "vitvinsvinäger" ||
                Bearnaisesås == "salt" ||
                Bearnaisesås == "gul lök" ||
                Bearnaisesås == "äggula" ||
                Bearnaisesås == "persilja" ||
                Bearnaisesås == "vatten")
                {
                    Console.WriteLine("Rätt svar!");
                    Console.WriteLine("Vill du fortsätta eller vill du stanna här och ta hem 20$?");
                    svar11 = Console.ReadLine();
                    svar11 = svar11.ToLower();

                    //kontrolerar svar och ställer fråga
                    if (svar11 == "fortsätta" || svar11 == "jag vill fortsätta")
                    {
                        Console.WriteLine("Vill du ha en sportfråga eller matte fråga?");
                        svar2 = Console.ReadLine();
                        svar2 = svar2.ToLower();

                        //kontrolerar svar och ställer fråga
                        if (svar2 == "sportfråga" || svar2 == "jag vill ha en sportfråga")
                        {
                            Console.WriteLine("vem har vunnit flest us open i golf?");
                            sport = Console.ReadLine();
                            sport = sport.ToLower();

                            //kontrolerar svar och gratulerar
                            if (sport == "tiger" || sport == "woods" || sport == "tiger woods")
                            {
                                Console.WriteLine("Rätt svar");
                                Console.WriteLine("Detta var slutet av denna frågesport du har vinnit 30$");
                            }
                        }
                        // kontrolerar svar och stälelr fråga
                        else if (svar2 == "mattefråga" || svar2 == "jag vill ha en mattefråga")
                        {
                            Console.WriteLine("Vad är (100)^(1/2)");
                            matte = int.Parse(Console.ReadLine());
                        }
                        //kontrolerar svar och gratulerar
                        if (matte == 10)
                        {
                            Console.WriteLine("Rätt svar");
                            Console.WriteLine("Detta var slutet av denna frågesport du har vinnit 30$");
                        }
                    }
                    else if (svar11 == "stanna" || svar11 == "jag vill stanna här")
                    {
                        Console.WriteLine("Här får du dina 20$");
                    }
                }
            }
            else if (svar1 == "stanna" || svar1 == "jag vill stanna här")
            {
                Console.WriteLine("Här får du dina 10$");
            }


            //kontrolerar svar och svarar












            //om inget stämer åvan så förlorar man
            else
            {
                Console.WriteLine("sry men du klarde inte det");
            }

        }
    }
}
