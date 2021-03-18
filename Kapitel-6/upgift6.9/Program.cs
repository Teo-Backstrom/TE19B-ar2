using System;

namespace upgift6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            double decimaltal = ReadDouble();
            Console.WriteLine($"Du skrev in talet {decimaltal}");

        }
        static double ReadDouble()
        {
            double tal;
            while (double.TryParse(Console.ReadLine(), out tal) == false)
            {
                Console.WriteLine("Du skrev inte in ett tal. Försök igen.");
            }
            return tal;
        }

    }
}
