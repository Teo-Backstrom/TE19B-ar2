using System;

namespace Konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            //ändra backroudsfärg och text färg i terminalen

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("ConsoleColor.Black");
            Console.WriteLine("Hello World!");
        }
    }
}
