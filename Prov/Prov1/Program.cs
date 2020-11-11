using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatning = "";
            double netto = 0;
            double brutto = 0;
            int omstart = 1;
            bool omstartsKoll = false;

            // loop tills användaren inte vill köra om
            while (omstart != 0)
            {
                //nollställer omstartsKoll
                omstartsKoll = false;

                //mata in hur mycket brutto lön
                Console.WriteLine("Hur mycket får du innan skatten som lön? (svara med numeriska siffror)");

                //loopar tills giltigt inmatning givits
                while (brutto <= 0)
                {
                    //mata in string brutto
                    string input = Console.ReadLine();
                    //Försöker översätta string till double
                    if (double.TryParse(input, out brutto))
                    {
                        // omvandrlar brutto till netto
                        if (brutto >= 0 && brutto < 10000)
                        {
                            netto = brutto * 0.92;
                        }
                        else if (brutto >= 10000 && brutto < 145000)
                        {
                            netto = brutto * 0.78;
                        }
                        else if (brutto >= 145000 && brutto < 515000)
                        {
                            netto = brutto * 0.67;
                        }
                        else if (brutto >= 515000)
                        {
                            netto = brutto * 0.47;
                        }
                        // felmedelande
                        else
                        {
                            Console.WriteLine("Skriv ett tal som är possitivt");
                        }
                    }
                    // felmedelande
                    else
                    {
                        Console.WriteLine("Använd bara numeriska symboler");
                    }
                }
                // skriver ut netto lön
                Console.WriteLine("Din netto lön är " + netto + "Kr");

                // loopar tills man får giltigtg svar
                while (omstartsKoll == false)
                {
                    // frågar om hen vill ha en omstart
                    Console.WriteLine("Vill du skriva in en till brutto lön mata in 1");
                    Console.WriteLine("Om du vill avsluta mata in 0");
                    //inamtning om hen vill starta om
                    inmatning = Console.ReadLine();
                    //kollar om det går att konvertera till int
                    if (int.TryParse(inmatning, out omstart))
                    {
                        // skrivs hejdå då användaren skriver 0 och slutar att loopa omstartskoll
                        if (omstart == 0)
                        {
                            Console.WriteLine("Hej då");
                            omstartsKoll = true;
                        }
                        // ger brutto värdet 0 och slutar loopa omstartskoll
                        else if (omstart == 1)
                        {
                            brutto = 0;
                            omstartsKoll = true;
                        }
                        //felmedelande
                        else
                        {
                            Console.WriteLine("Skriv ett tal antingen 1 eller 0");
                        }
                    }
                    //felmedelande
                    else
                    {
                        Console.WriteLine("Använd numeriska siffror och välj mellan 0 eller 1");
                    }
                }

            }
        }
    }
}
