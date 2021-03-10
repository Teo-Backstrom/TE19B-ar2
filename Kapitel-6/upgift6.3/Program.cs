using System;

namespace upgift6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivTalIKvadratMellan(3, 5);
        }
        static void SkrivTalIKvadratMellan(int nedreGräns, int övreGräns)
        {
            for (int i = nedreGräns; i <= övreGräns; i++)
            {
                Console.WriteLine($"talet {i} i kvadrat är {i * i}");
            }
        }
    }
}
