/*skapa ett progam där användaren får skriva in en mening (utan punkt) som består av två ord. Skriv ut orden till användaren i omvänd ordning.*/

using System;

namespace Upgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv två ord: ");
            string namn = Console.ReadLine();

            int position = namn.IndexOf(" ");

            string x = namn.Substring(0, position);
            string z = namn.Substring(position + 1);

            Console.WriteLine(z + " " + x);
        }
    }
}
