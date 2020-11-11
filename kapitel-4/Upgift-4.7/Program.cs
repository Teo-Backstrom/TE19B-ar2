using System;

namespace Upgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            string text = Console.ReadLine();

            int summa = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string teckenString = text[i].ToString();
                int tal = int.Parse(teckenString);
                summa += tal;
            }

            Console.WriteLine($"Siffersumman av talet {text} är {summa}");
        }
    }
}
