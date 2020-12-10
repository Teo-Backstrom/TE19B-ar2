using System;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en labyrint

            int[,] labyrint = /*new int [5,5]*/{
                {1,1,1,1,1},  // y= 0
                {0,0,0,0,1},  // y= 1
                {1,0,1,0,1},
                {1,0,1,0,0},
                {1,0,1,1,1} 
            };

            //for att skriva ut utf-tecken

Console.OutputEncoding = System.Text.Encoding.Default;
            //loopa igenom raderna
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    //om 1 skriv ut svart annars vit fyrkant
                    if (labyrint[y,x]==1)
                    {
                        Console.Write("\u2B1C");
                    }
                    else
                    {
                        Console.Write("\u2B1B");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
