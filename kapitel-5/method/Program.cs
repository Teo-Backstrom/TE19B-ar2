using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHi("Teo");
            Console.WriteLine("Hello World!");
        }

        static void SayHi(string name){
            Console.WriteLine("hi " + name);
        }
    }
}
