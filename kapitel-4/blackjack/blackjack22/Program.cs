﻿using System;

namespace blackjack22
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int svar = 1;

            while (summa < 21)
            {
                if (summa < 21)
                {
                    if (svar == 1)
                    {
                        //slulmpa fram ett tal 1-6
                        Console.WriteLine("hur många kort vill du ha");
                        int antal = int.Parse(Console.ReadLine());
                        for (int i = 0; i < antal; i++)
                        {
                            Random tarning = new Random();
                            int slumptal = tarning.Next(1, 10);
                            Console.WriteLine(slumptal);

                            summa = slumptal + summa;
                        }
                        Console.WriteLine(summa);
                        Console.WriteLine("vill du ha fler kort j/n");
                        string svar2 = Console.ReadLine();
                        if (svar2 == "j")
                        {
                            svar = 1;
                        }
                        else
                        {
                            svar = 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine(summa);
                    }
                }
                else
                {
                    Console.WriteLine("du belv tjock");
                }

            }

        }
    }
}
