using System;

namespace upgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //SKAPA EN ARRAY MED 8 TAL
            int[] tal = { 1, 5, 8, 2, 3, 2, 3, 7 };

            // SKAPA EN VARIABEL SOM SKA INNEHÅLL MAX VÄRDET
            int max = 0;
            //gå igenom arryn med en loop
            for (int i = 0; i < tal.Length; i++)
            {
                if (max < tal[i])
                {
                    max = tal[i];
                }
            }
            Console.WriteLine($"största talet är {max}");
        }
    }
}
