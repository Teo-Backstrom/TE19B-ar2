using System;

namespace Uppgift_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            RitaRätvinkligTriangel(3);

        }

        static void RitaRätvinkligTriangel(int sidlängd)
        {
            for (int y = 1; y <= sidlängd; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}

