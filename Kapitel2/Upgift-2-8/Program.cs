using System;

namespace Upgift_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv två tal: ");
            string tal = Console.ReadLine();


            int position = tal.IndexOf("+");

            int x = int.Parse(tal.Substring(0, position));
            int z = int.Parse(tal.Substring(position + 1));

            int summa = x + z;
            Console.WriteLine(summa);
        }
    }
}
