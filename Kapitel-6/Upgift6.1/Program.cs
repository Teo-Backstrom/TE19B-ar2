using System;

namespace Upgift6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivTalIKvadrat(2);
            SkrivTalIKvadrat(4);
            SkrivTalIKvadrat(2);
            SkrivTalIKvadrat(9);
        }
        static void SkrivTalIKvadrat(int tal)
        {

            int produkt = tal * tal;
            Console.WriteLine(produkt);
        }
    }
}
