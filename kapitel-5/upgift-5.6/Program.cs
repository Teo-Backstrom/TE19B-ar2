using System;

namespace upgift_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa array
            string[] städer = new string[5];
            //informatjon till ndvändaren
            Console.WriteLine("Skriv in 5 städer");

            //lt användare skriva in 5 gågner
            for (int i = 0; i < städer.Length; i++)
            {
                städer[i] = Console.ReadLine();
            }

            //skriv ut allt
            foreach (var stad in städer)
            {
                Console.WriteLine(stad);
            }

        }
    }
}
