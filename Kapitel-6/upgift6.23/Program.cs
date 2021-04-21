using System;

namespace upgift6._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string meddelande = Console.ReadLine();

            Console.WriteLine(GörFörstaBokstavStor2(meddelande));

        }

        static string GörVarannanStor(string mening)
        {
            mening = mening.ToLower();
            string[] ord = mening.Split(" ");

            for (int i = 0; i < ord.Length; i += 2)
            {
                ord[i] = ord[i].ToUpper();
            }
            return String.Join(" ", ord);
        }

        static string GörFörstaBokstavStor(string mening)
        {
            string[] ord = mening.Split(" ");

            for (int i = 0; i < ord.Length; i++)
            {
                ord[i] = ord[i].Replace(ord[i].Substring(0, 1), ord[i].Substring(0, 1).ToUpper());


            }
            return String.Join(" ", ord);
        }
        static string GörFörstaBokstavStor2(string mening)
        {
            string[] ord = mening.Split(" ");

            for (int i = 0; i < ord.Length; i++)
            {
                ord[i] = ord[i].Substring(0, 1).ToUpper() + ord[i].Substring(1).ToLower();


            }
            return String.Join(" ", ord);
        }
    }
}
