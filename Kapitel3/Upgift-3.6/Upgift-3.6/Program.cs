using System;

namespace Upgift_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in ålder
            Console.WriteLine("Hur gammal är du");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder > 65 || 10 < ålder && ålder < 18)
            {

                Console.WriteLine("du får extra pris");


            }
            else
            {
                Console.WriteLine("du får INTE extrapris");
            }
        }
    }
}
