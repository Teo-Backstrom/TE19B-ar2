using System;

namespace upgift_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mineing!");

            string mening = Console.ReadLine();

            string[] ord = mening.Split(' ');

            foreach (var ordet in ord)
            {
                Console.WriteLine(ordet);
            }
        }
    }
}
