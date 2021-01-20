using System;

namespace Labyrint
{
    class Program
    {
        static void Main(string[] args)
        {

            int poang = 0;
            // För att skriva ut Entities
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Slumpa fram in en tomte i labyrinten
            Random slumpMotor = new Random();

            // Skapa en labyrint
            int[,] labyrint = {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},  // 0
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},  // 1
                {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1},  // 2
                {1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1},  // 3
                {1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1},  // 4
                {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},  // 5
                {1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1},  // 6
                {1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1},  // 7
                {1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1},  // 8
                {1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1}   // 9
            };
            //var är spelare
            int spelarePosX = 1;
            int spelarePosY = 9;
            // Placera ut tomtar
            int antalTomtar = 3;
            while (antalTomtar != 0)
            {
                // Slumpa fram koordinater
                int x = slumpMotor.Next(0, 11);  // 0-10
                int y = slumpMotor.Next(0, 10);  // 0-9

                // Hamnar figuren i en gång?
                if (labyrint[y, x] == 0)
                {
                    labyrint[y, x] = 2;
                    antalTomtar--;

                }
            }



            //Spellopen
            while (true)
            {
                Console.Clear();
                //infoga spelaren
                labyrint[spelarePosY, spelarePosX] = 3;
                Console.WriteLine(poang);
                // Skriva ut labyrinten
                // Loopa igenom rad för rad, dvs i y-led
                for (int y = 0; y < 10; y++)
                {
                    // Loopa igenom kolumnvis, dvs x-led
                    for (int x = 0; x < 11; x++)
                    {
                        switch (labyrint[y, x])
                        {
                            case 1: // En vägg
                                Console.Write('\u2B1C');
                                break;

                            case 2: // En tomte
                                Console.Write("0 ");
                                break;

                            case 3: // En spelare
                                Console.Write("# ");
                                break;

                            default: // En gång
                                Console.Write('\u2B1B');
                                break;
                        }
                    }
                    Console.WriteLine();
                }

                //frpga användren vart spelaren ska gå
                Console.WriteLine("Vart vill du gå?(wasd)");
                // läas in omvandal till stora bokstäver och ta första tecknet.
                string riktning = Console.ReadLine().ToUpper().Substring(0, 1);

                //radera position spelaren
                labyrint[spelarePosY, spelarePosX] = 0;
                switch (riktning)
                {
                    case "A":
                        if (labyrint[spelarePosY, spelarePosX - 1] != 1)
                        {
                            spelarePosX--;
                        }
                        break;
                    case "D":
                        spelarePosX++;
                        break;
                    case "W":
                        spelarePosY--;
                        break;
                    case "S":
                        spelarePosY++;
                        break;
                    default:
                        Console.WriteLine("Förstod inte vad du menar. Vg försök igen");
                        break;
                }

                if (labyrint[spelarePosY, spelarePosX] == 2)
                {
                    poang++;
                }



            }

        }
    }
}