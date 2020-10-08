using System;

namespace Upgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string land = "";

            while (land != "kina")
            {
                Console.WriteLine("Vad är värdens folkriskade land?");
                land = Console.ReadLine();
                land = land.ToLower();
                if (land != "kina")
                {
                    Console.WriteLine("fel svar försök igen");

                }
                else
                {
                    Console.WriteLine("Rättsvar hejdå");
                }

            }

        }
    }
}
