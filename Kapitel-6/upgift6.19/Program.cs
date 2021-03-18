using System;

namespace upgift6._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = Störst(2, 4);
            Console.WriteLine(tal);
        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }


        }
    }
}
