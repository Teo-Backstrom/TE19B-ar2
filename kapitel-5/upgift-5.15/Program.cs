using System;

namespace Uppgift_5._15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ordLista = { "Lag", "Nej", "bl", "Al", "Best" };

            string först = ordLista[0];

            for (int i = 1; i < ordLista.Length; i++)
            {
                if (ordLista[i].CompareTo(först) < 0)
                {
                    först = ordLista[i];
                }

            }

            Console.WriteLine($"Först i bokstavsordning: {först}");

        }
    }
}
