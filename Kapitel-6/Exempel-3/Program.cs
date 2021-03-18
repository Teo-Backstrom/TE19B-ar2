using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summera(99, 123));

            string omvändText = VändText("Programering");
            Console.WriteLine(omvändText);

        }
        static int Summera(int tal1, int tal2)
        {
            int summa = tal1 + tal2;
            return summa;
        }

        static string VändText(string text)
        {
            string omvändText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                omvändText += text[i];
            }

            return omvändText;
        }

    }
}
