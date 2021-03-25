using System;

namespace upgift6._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int menyVal = 0;
            while (menyVal != 3)
            {
                Console.WriteLine("1.Addera 3 tal");
                Console.WriteLine("2.Största av 2 tal");
                Console.WriteLine("3. avlsuta");
                menyVal = ReadInt();

                switch (menyVal)
                {
                    case 1:
                        MenyAddera();
                        break;
                    case 2:
                        MenyStörst();
                        break;
                    case 3:
                        Console.WriteLine("hejdå");
                        break;

                    default:
                        Console.WriteLine("ickegiltigt val, försök igen");
                        break;
                }
            }
        }

        /// <summary>
        /// Adderar tre heltal
        /// </summary>
        /// <param name="tal1">Det ena talet</param>
        /// <param name="tal2">Det andra talet</param>
        /// <param name="tal3">Det tredje talet</param>
        /// <returns>Summan av talen</returns>

        static void MenyAddera()
        {
            Console.WriteLine("skriv 3 tal");
            int tal1 = ReadInt();
            int tal2 = ReadInt();
            int tal3 = ReadInt();
            int summa = Addera(tal1, tal2, tal3);
            Console.WriteLine(summa);

        }

        /// <summary>
        /// får ut det största talet av 2 tal
        /// </summary>
        /// <param name="tal1">Det ena talet</param>
        /// <param name="tal2">Det andra talet</param>
        /// <returns>största talet</returns>
        static void MenyStörst()
        {
            Console.WriteLine("skriv 2 tal");
            int tal1 = ReadInt();
            int tal2 = ReadInt();
            int störst = Störst(tal1, tal2);
            Console.WriteLine(störst);

        }

        /// <summary>
        /// parsar string till int
        /// </summary>
        /// <param name="heltal">talet som returnas</param>
        /// <returns>heltal</returns>
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }


        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }


        }
    }
}
