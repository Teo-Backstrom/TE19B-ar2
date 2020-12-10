using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(cube(5));
        }

        static int cube(int num)
        {
            int resultat = num * num * num;
            return resultat;
        }
    }
}
