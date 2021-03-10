using System;

namespace upgift6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("hej");
            SkrivBaklänges("jasidjaoij");
            SkrivBaklänges("Jg gillar glass");
            SkrivBaklänges("Snart är det vår");
        }
        static void SkrivBaklänges(string meddelande)
        {

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
        }
    }
}