using System;

namespace upgift_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] åldrar = new int[100];
            int antal = 0;
            string svar = "";


            while (svar != "n" && antal < åldrar.Length)
            {
                Console.WriteLine("Skriv in en ålder");


                string inmatning = Console.ReadLine();
                while (!int.TryParse(inmatning, out åldrar[antal]))
                {
                    Console.WriteLine("Skriv in en ålder med siffror");
                    inmatning = Console.ReadLine();
                }
                antal++;
                if (antal == åldrar.Length)
                {
                    Console.WriteLine("Programmet har inte plats för fler åldrar");
                }
                else
                {
                    Console.WriteLine("Vill du skriva in fler åldrar? (j/n)");
                    svar = Console.ReadLine();
                }
            }

            Console.WriteLine("De åldrar du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(åldrar[i]);
            }
        }
    }
}
