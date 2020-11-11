using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tal tack");
            string tal = Console.ReadLine();

            for (int i = 0; i < tal.Length; i++)
            {
                string addering = tal[i].ToString();
                int näst = int.Parse(addering);

                if (näst == 9)
                {
                    näst = 0;
                }
                else
                {
                    näst++;
                }

                Console.Write(näst);
            }
        }
    }
}
