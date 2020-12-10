using System;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en labyrint

            int[,] labyrint = /*new int [5,5]*/{
                {1,1,1,1,1,1,1,1,1,1},  // y= 0
                {0,0,0,0,1,3,2,1,2,3},  // y= 1
                {1,0,1,0,1,1,2,3,1,2},
                {1,0,1,0,0,1,3,3,3,2},
                {1,0,1,1,1,1,2,3,3,1},
                {1,2,3,3,3,2,2,2,1,1},
                {1,2,3,1,1,1,2,2,3,1},
                {1,2,3,1,3,2,1,2,3,1},
                {3,3,3,3,3,3,1,1,1,1},
                {1,2,3,1,2,3,3,3,1,2}
            };

            //for att skriva ut utf-tecken

            Console.OutputEncoding = System.Text.Encoding.Default;
            //loopa igenom raderna
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    //om 1 skriv ut svart annars vit fyrkant
                    if (labyrint[y, x] == 1)
                    {
                        Console.Write("\u20B1");
                    }
                    else if (labyrint[y, x] == 2)
                    {
                        Console.Write("\u20AA");
                    }
                    else
                    {
                        Console.Write("\u26C5");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
