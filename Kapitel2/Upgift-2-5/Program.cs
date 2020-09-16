//Skapa ett program som frågar användaren vilket år det är, därefter ska programmet säga hur många år det är kvar till år 2100.
using System;

namespace Upgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nuÅr = 0;
            int årKvar = 0;

            Console.WriteLine("Vilet år är det");

            nuÅr = int.Parse(Console.ReadLine());

            årKvar = 2100 - nuÅr;

            Console.WriteLine("Antal år kvar till 2100 är " + årKvar + " år");
        }
    }
}
