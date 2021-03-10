using System;

namespace Uppgift_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2*5 = {Multiplicera(2, 5)}");
            Console.WriteLine($"4/4 = {Dividera(4, 4)}");
        }
        static double Multiplicera(double tal1, double tal2)
        {
            return tal1 * tal2;
        }
        static double Dividera(double tal1, double tal2)
        {
            return tal1 / tal2;
        }
    }
}
