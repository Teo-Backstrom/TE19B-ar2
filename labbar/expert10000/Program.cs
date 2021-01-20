using System;

namespace expert10000
{
    class Program
    {
        static void Main(string[] args)
        {
            //hur många timmer vill du träna / dag

            Console.WriteLine("hur måga timmar vill di träna för dag");
            string svar = Console.ReadLine();
            double antalTimmar = 0;

            //kontrolera att användaren matar in ett tal
            //isåfall översätt till tal
            while (!double.TryParse(svar, out antalTimmar) && antalTimmar <= 0)
            {
                Console.WriteLine("Ogitigt input försök igen");
                svar = Console.ReadLine();
            }

            // räkna ut när man blir klar
            DateTime datumKlar = DateTime.Today.AddDays(1000 / antalTimmar);
            TimeSpan hurLångTid = datumKlar - DateTime.Today;

            //räkna ut antal år
            int antalÅr = hurLångTid.Days / 365;

            Console.WriteLine("du måste träna i " + antalÅr + "år" + datumKlar);
            //Console.WriteLine(datumKlar);

        }
    }
}
