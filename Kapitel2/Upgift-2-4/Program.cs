//Skapa ett program som frågar användaren efter två tal. Programmet ska sedan beräkna och skriva ut summan av talen och därefter produkten av talen.

using System;

namespace Upgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in första argumentet
            int x = int.Parse(args[0]);

            //läs in andra
            int y = int.Parse(args[1]);

            /*     float x = 0;
                float y = 0;
                float summan = 0;
                float producten = 0; */

            /* Console.WriteLine("Ett tal");
            x = float.Parse(Console.ReadLine());

            //längd i meter
            Console.WriteLine("ett till");
            y = float.Parse(Console.ReadLine());
 */
            int summan = x + y;
            int producten = x * y;
            Console.WriteLine("Detta är summan av dina tal");

            Console.WriteLine(summan);

            Console.WriteLine("Och producten är lika med");
            Console.WriteLine(producten);



        }
    }
}
