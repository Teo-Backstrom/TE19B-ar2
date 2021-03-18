using System;

namespace Uppgift_6._13
{
    class Program
    {
        static Random slump = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine($"Året är {SlumpaÅrtal()} och månaden är {SlumpaMånad()}");
        }

        /// <summary>
        /// Slumpar heltal mellan 1900-1999
        /// </summary>
        /// <returns>slump mellan 1900 och 2000</returns>
        static int SlumpaÅrtal()
        {
            return slump.Next(1900, 2000);
        }

        /// <summary>
        /// Slumpar heltal mellan 1-12
        /// </summary>
        /// <returns>slump mellan 1-13</returns>
        static int SlumpaMånad()
        {
            return slump.Next(1, 13);
        }
    }
}
