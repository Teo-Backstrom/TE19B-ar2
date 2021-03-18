using System;

namespace upgift6._14
{
    class Program
    {

        static Random slump = new Random();
        static void Main(string[] args)
        {
            SlumpaPosition();
        }
        /// <summary>
        /// Genererar x position för schack
        /// </summary>
        /// <returns>Tal mellan 1-9</returns>
        static int SlumpRad()
        {
            return slump.Next(1, 9);
        }
        /// <summary>
        /// Genererar y position för schack
        /// </summary>
        /// <returns>bokstav mellan a-i</returns>
        static char SlumpKolumn()
        {
            string positioner = "abcdefgh";

            return positioner[slump.Next(0, 8)];
        }

        /// <summary>
        /// sätter ihop slumprad och slump kolumn till ett
        /// </summary>
        static void SlumpaPosition()
        {
            Console.WriteLine($"{SlumpRad()}{SlumpKolumn()}");
        }
    }
}
