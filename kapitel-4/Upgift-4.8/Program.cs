using System;

namespace Upgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool koll = false;

            Console.WriteLine("Skriv in ett tal");
            string tal = Console.ReadLine();



            for (int i = 0; i < tal.Length; i++)
            {
                if (tal[i] == '3' || tal[i] == '7')
                {
                    koll = true;
                }
            }

            if (koll == true)
            {
                Console.WriteLine("Talet har 3 eller 7");
            }
            else
            {
                Console.WriteLine("Ingen 3 eller 7");
            }
        }
    }
}
