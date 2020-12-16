using System;

namespace labyrint
{
    class Program
    {
        static void Main(string[] args)
        {
            //För att skriva ut enteties
            Console.OutputEncoding = System.Text.Encoding.Default;

            // Skapa en matris med strängar
            int[,] karta = {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 0, 1},
                {1, 0, 1, 1, 0, 0, 1},
                {1, 0, 1, 1, 0, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 1, 1}
            };
            //slumpa fram in en figur i labyrinten
            Random slumpmotor = new Random();
            while (true)
            {
                // slumpa fram kordinater
                int x = slumpmotor.Next(0, 7);
                int y = slumpmotor.Next(0, 7);

                //manar vi i en gång
                if (karta[y, x] == 0)
                {
                    karta[y, x] = 2;
                    break;
                }

            }



            //skriva ut labyrinten
            //loopa igenom rad för rad
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    switch (karta[y, x])
                    {
                        case 1:
                            Console.Write('\u2B1C');
                            break;

                        case 2:
                            Console.Write("⏺ ");
                            break;

                        default:
                            Console.Write('\u2B1C');
                            break;
                    }

                }
                Console.WriteLine();
            }
            int x = slumpmotor.Next(0, 7);
            int y = slumpmotor.Next(0, 7);
            Console.WriteLine("hur vill du gå");
            string inmatning = Console.ReadLine();

            switch (inmatning)
            {
                case "w":
                    y--;
                    break;

                case "s":
                    y++;
                    break;

                case "a":
                    x--;
                    break;

                case "d":
                    x++;
                    break;
                default:
            }
            //skriva ut labyrinten
            //loopa igenom rad för rad
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    switch (karta[y, x])
                    {
                        case 1:
                            Console.Write('\u2B1C');
                            break;

                        case 2:
                            Console.Write("⏺ ");
                            break;

                        default:
                            Console.Write('\u2B1C');
                            break;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
