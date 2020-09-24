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

            if (fingrar == 5)
            {
                Console.WriteLine("Rätt svar");
                Console.WriteLine("Vill du fortsätta eller vill du stanna här och ta hem 10$?");
                string svar1 = Console.ReadLine();
                svar1 = svar1.ToLower();

                if (svar1 == stanna || svar1 == jag vill stanna)
                {
                    Console.WriteLine("Här får du dina 10$");
                }

                else if (svar1 == fortsätta || svar1 == jag vill fortsätta )
                {
                    Console.WriteLine("Nästa fråga är");
                    Console.WriteLine("Nämn en ingredisens i Bearnaisesås");
                    string Bearnaisesås = Console.ReadLine();
                    Bearnaisesås = Bearnaisesås.ToLower();
                }

            }
            if (Bearnaisesås == smör || Bearnaisesås == schalottenlök || Bearnaisesås == fransk dragon ||
            Bearnaisesås == vitpeppar || Bearnaisesås == rödvinsvinäger || Bearnaisesås == vitvinsvinäger ||
            Bearnaisesås == salt || Bearnaisesås == gul lök || Bearnaisesås == äggula || Bearnaisesås == persilja
            || Bearnaisesås == vatten)
            {
                Console.WriteLine("Rätt svar!");
            }

        }
    }
}
