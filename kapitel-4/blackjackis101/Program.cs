using System;

namespace blackjackis101
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int summaPlayer = 0;
            bool flagga = true;
            //2 random kort till båda spelarna och adera dem
            for (int i = 0; i < 2; i++)
            {
                Random tarning = new Random();
                int slumptal = tarning.Next(1, 10);

                Random tarningPlayer = new Random();
                int slumptalPlayer = tarningPlayer.Next(1, 10);

                summa = summa + slumptal;
                summaPlayer = summaPlayer + slumptalPlayer;
            }
            //ge ut vilken summa spelaren har
            Console.WriteLine("din summa är " + summaPlayer);

            //låt hen välja hur många kort på raken hen vill ha
            while (flagga == true)
            {
                //om hen har under 22 så fårhen ta nytt kort om hen vill
                if (summaPlayer < 22)
                {
                    Console.WriteLine("vill du ha ett till kort? j/n");
                    string svar = Console.ReadLine();
                    svar = svar.ToLower();
                    if (svar == "j")
                    {
                        Random tarningPlayer = new Random();
                        int slumptalPlayer = tarningPlayer.Next(1, 10);
                        summaPlayer = summaPlayer + slumptalPlayer;
                        Console.WriteLine(summaPlayer);
                    }
                    //hen behöver inte ta nytt kort och slutar
                    else if (svar == "n")
                    {
                        flagga = false;

                        //dealern tar kort till hen har mer än spelare
                        while (summa < summaPlayer)
                        {
                            Random tarning = new Random();
                            int slumptal = tarning.Next(1, 10);

                            summa = summa + slumptal;

                        }

                        //om dealer har mer än 21 så vinner Spelare
                        if (summa > 21)
                        {
                            Console.WriteLine("du vann för han blev tjock: din summa " + summaPlayer + " hans summa " + summa);
                        }
                        //om dealer har mer än spelare så vinner dealer
                        else if (summa > summaPlayer)
                        {
                            Console.WriteLine("du förlorade han fick mer poäng än dig: din summa " + summaPlayer + " hans summa " + summa);
                        }

                    }
                    else
                    {
                        Console.WriteLine("skriv j eller n");
                    }
                }
                //om spealre blir tjock vinner dealer
                else
                {
                    Console.WriteLine("du blev tjock: din summa " + summaPlayer + " hans summa " + summa);
                    flagga = false;

                }


            }
        }


    }
}

