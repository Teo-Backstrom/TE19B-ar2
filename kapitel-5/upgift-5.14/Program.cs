using System;

namespace Uppgift_5._14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];

            frågor[0] = "1+3";
            svar[0] = "4";

            frågor[1] = "1*1";
            svar[1] = "1";

            frågor[2] = "89*0";
            svar[2] = "0";

            frågor[3] = "5*1";
            svar[3] = "5";

            Console.WriteLine("Välj en fråga (1 - 4)");
            int frågeIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(frågor[frågeIndex]);
            string användarensSvar = Console.ReadLine();

            if (användarensSvar == svar[frågeIndex])
            {
                Console.WriteLine("Du svarade rätt!");
            }
            else
            {
                Console.WriteLine("Du svarade fel");
            }

        }
    }
}
