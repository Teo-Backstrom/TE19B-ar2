using System;

namespace upgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] städer = new string[3];

            städer[0] = "stockholm";
            städer[1] = "göteborg";

            for (int i = 0; i < 2; i++)
            {
                Console.Write(städer[i] + " ");
            }

            Console.WriteLine("skriv in en stad");
            städer[2] = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(städer[i] + " ");
            }

        }

    }
}
