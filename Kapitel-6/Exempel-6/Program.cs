using System;

namespace Exempel_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("hej");
            SkrivVertikalt(12);
        }

        static void SkrivVertikalt(string meddelande){
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            }
        }

        static void SkrivVertikalt(int tal){
            SkrivVertikalt(tal.ToString());
        }
    }
}
