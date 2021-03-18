using System;

namespace upgift6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AntalSträng('m', "Mumma"));
        }
        static int AntalSträng(char tecken, string text)
        {
            int antal = 0;
            string småBokstäver = text.ToLower();
            for (int i = 0; i < småBokstäver.Length; i++)
            {
                if (småBokstäver[i] == tecken)
                {
                    antal++;
                }
            }
            return antal;
        }
    }
}
