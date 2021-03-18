using System;

namespace upgift6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Längst("hej", "hejdå"));
        }
        static string Längst(string text1, string text2)
        {

            if (text1.Length > text2.Length)
            {
                return text1;
            }
            else if (text1.Length < text2.Length)
            {
                return text2;
            }
            else
            {
                return text1;
            }
        }
    }
}
