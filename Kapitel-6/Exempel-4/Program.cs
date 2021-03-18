using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = ReadInt();
            Console.WriteLine(tal + 1);
        }

        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
