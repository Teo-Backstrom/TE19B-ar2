using System;

namespace upgift6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv vad som");
            int svar;
            if (!int.TryParse(Console.ReadLine(), out svar))
            {
                Console.WriteLine("du skrev inte ett heltal");
            }
            else
            {
                Console.WriteLine("du skrev ett heltal");
            }
        }
    }
}
