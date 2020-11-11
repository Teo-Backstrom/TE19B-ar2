using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int StartaOm = 0;
            int poang = 0;
            string namn = "";
            int svar1 = 0;
            int svar2 = 0;
            int svar3 = 0;
            //ange namn
            Console.WriteLine("Vad heter du?");
            namn = Console.ReadLine();
            while (StartaOm != 1)
            {
                //frågor
                Console.WriteLine(namn + ", Hur många fingrar har men på en hand? Svara med 1,2 eller 3");
                Console.WriteLine("1. Tre fingrar 2. Fem fingrar 3. Tio fingrar");


                string gissning1 = Console.ReadLine();

                if (int.TryParse(gissning1, out svar1))
                {
                    if (svar1 == 2)
                    {
                        Console.WriteLine("Rätt svar");
                        poang++;
                    }
                    else if (svar1 != 2)
                    {
                        Console.WriteLine("Felsvar");
                    }
                    Console.WriteLine(namn + ", Hur många ben har en spindel? Svara med 1,2 eller 3");
                    Console.WriteLine("1. Tre ben 2. Fem ben 3. Åtta ben");


                    string gissning2 = Console.ReadLine();

                    if (int.TryParse(gissning2, out svar2))
                    {
                        if (svar2 == 3)
                        {
                            Console.WriteLine("Rätt svar");
                            poang++;
                        }
                        else if (svar2 != 3)
                        {
                            Console.WriteLine("Felsvar");
                        }
                        Console.WriteLine(namn + ", Hur ben har ett lejon? Svara med 1,2 eller 3");
                        Console.WriteLine("1. Tre Ben 2. Fem ben 3. Fyra ben");


                        string gissning3 = Console.ReadLine();

                        if (int.TryParse(gissning3, out svar3))
                        {
                            if (svar3 == 3)
                            {
                                Console.WriteLine("Rätt svar");
                                poang++;
                            }
                            else if (svar3 != 3)
                            {
                                Console.WriteLine("Felsvar");
                            }
                            Console.WriteLine("Nu är frågesporten klar och du fick " + poang + " poäng.");
                            Console.WriteLine("Om du vill köra igen tryck på 0 vill du sluta här tryck på 1");
                            StartaOm = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("ge ett giltigt svar du får ett minuspoäng");
                            poang--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ge ett giltigt svar du får ett minuspoäng");
                        poang--;
                    }
                }
                else
                {
                    Console.WriteLine("ge ett giltigt svar du får ett minuspoäng");
                    poang--;
                }





            }
        }
    }
}
