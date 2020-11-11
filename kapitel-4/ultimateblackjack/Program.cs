using System;

namespace ultimateblackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //globala variabler
            int summa = 0;
            bool svar = true;
            int summaPlayer = 0;
            //datorns / dealerns hand först dra 2 kort
            for (int i = 0; i < 2; i++)
            {
                Random tarning = new Random();
                int slumptal = tarning.Next(1, 10);

                summa = summa + slumptal;
            }
            //fortsätter tills 18 eller mer
            while (summa < 18)
            {
                Random tarning = new Random();
                int slumptal = tarning.Next(1, 10);

                summa = summa + slumptal;

            }
            Console.WriteLine(summa);




        }
    }
}

/*
for (int iPlayer = 0; iPlayer < 2; iPlayer++)
            {
                Random tarningPlayer = new Random();
                int slumptalPlayer = tarningPlayer.Next(1, 10);
                Console.WriteLine(slumptalPlayer);

                summaPlayer = summaPlayer + slumptalPlayer;
            }
            Console.WriteLine(summaPlayer);

            while (summaPlayer < 22)
            {
                while (svar == true)
                {
                    string svarString = "";
                    while (svarString != "j" || svarString != "n")
                    {
                        Console.WriteLine("vill du ha ett till kort? j/n");
                        svarString = Console.ReadLine();
                        svarString = svarString.ToLower();

                        if (svarString == "j")
                        {
                            Random tarningPlayer = new Random();
                            int slumptalPlayer = tarningPlayer.Next(1, 10);
                            Console.WriteLine(slumptalPlayer);

                            summaPlayer = summaPlayer + slumptalPlayer;
                            Console.WriteLine(summaPlayer);
                        }
                        else if (svarString == "n")
                        {
                            svar = false;
                        }
                        else
                        {
                            Console.WriteLine("svara j eller n");
                        }
                    }
                    Console.WriteLine("2");
                }
                if (21 - summaPlayer < 21 - summa)
                {
                    Console.WriteLine("du vann din summa blev " + summaPlayer + " och dealerns summa blev" + summa);
                }
                else
                {
                    Console.WriteLine("du förlorade din summa blev " + summaPlayer + " och dealerns summa blev" + summa);
                }
            }
            Console.WriteLine("du förlora du blev tjock din summma blev " + summaPlayer);
