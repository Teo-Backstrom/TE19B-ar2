using System;

namespace upgift6._16
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("hej", 2, 2);
        }
        static void SkrivVertikalt(string TextVal, int rader = 0, int stegHöger = 0)
        {

            for (int i = 0; i < TextVal.Length; i++)
            {
                for (int x = 0; x < stegHöger; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(TextVal[i]);

                for (int y = 0; y < rader; y++)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
