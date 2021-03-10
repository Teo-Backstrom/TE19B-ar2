using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vi skriver ut text vertikalt");


            SkrivVertikalt("MetoderYYA");


            SkrivVertikalt("Metodaer är kul");

        }

        //en metod för att skriva text vertikalt
        //Parameter string TextVal
        static void SkrivVertikalt(string TextVal)
        {

            for (int i = 0; i < TextVal.Length; i++)
            {
                Console.WriteLine(TextVal[i]);
            }
        }
    }
}
