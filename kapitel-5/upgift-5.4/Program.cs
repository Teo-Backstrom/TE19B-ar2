using System;

namespace upgift_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] årtal = { 1300, 1400, 1400, 1500, 1600 };
            bool flagga = false;

            Console.WriteLine("Gissa ett årtal");
            int gissning = int.Parse(Console.ReadLine());

            for (int i = 0; i < årtal.Length; i++)
            {
                if (årtal[i] == gissning)
                {
                    flagga = true;
                }
            }
            if (flagga)
            {
                for (int i = 0; i < årtal.Length; i++)
                {
                    Console.WriteLine(årtal[i]);
                }
            }
            else
            {
                Console.WriteLine("Årtalet kunde inte hittas");
            }
        }
    }
}

