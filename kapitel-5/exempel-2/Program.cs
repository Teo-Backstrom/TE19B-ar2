using System;

namespace exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en text: ");
            string text = Console.ReadLine();

            // Dela upp texten i separata ord.

            string[] orden = text.Split(' ');

            //Loopa igenom arrayen
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }
        }
    }
}
