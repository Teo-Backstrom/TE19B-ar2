using System;

namespace upgift_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tal med + mellan talen!");

            string ekvationen = Console.ReadLine();

            string[] siffror = ekvationen.Split('+');

            int summa = 0;

            foreach (var siffra in siffror)
            {
                int tal = int.Parse(siffra);

                summa += tal;
            }

            Console.WriteLine(summa);
        }
    }
}