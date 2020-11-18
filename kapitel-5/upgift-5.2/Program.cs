using System;

namespace upgift_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många sporter har du uthövat");

            int antal = int.Parse(Console.ReadLine());

            string[] sporter = new string[antal];
            Console.WriteLine("skriv ned vilka sporter du gått på");
            for (int i = 0; i < sporter.Length; i++)
            {
                sporter[i] = Console.ReadLine();
            }

            for (int i = 0; i < sporter.Length; i++)
            {
                Console.WriteLine(sporter[i]);
            }
        }
    }
}
