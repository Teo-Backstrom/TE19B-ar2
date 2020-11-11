using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            for (double i = 10; i > 0; i--)
            {
                Console.WriteLine(a);
                i++;
                a = a / 10;
            }
        }
    }
}
