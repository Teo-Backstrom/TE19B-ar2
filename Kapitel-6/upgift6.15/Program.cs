using System;

namespace upgift6._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Baklänges("hello WOrld");
            Baklänges(123123);
            Baklänges(123.13123);
        }
        static void Baklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
        }
        static void Baklänges(int tal)
        {
            Baklänges(tal.ToString());
        }
        static void Baklänges(double tal2)
        {
            Baklänges(tal2.ToString());
        }
    }
}
