using System;

namespace kapitel_5.morse
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "j";

            while (svar != "n")
            {
                Console.WriteLine("skriv en bokstav");
                string bokstav = Console.ReadLine();

                bokstav = bokstav.ToUpper();

                string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";


                int index = alfabetet.IndexOf(bokstav);

                Console.WriteLine(bokstav + " finns på plats nr " + index);


                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

                string morseBokstav = morse[index];
                Console.WriteLine(morse[index]);

                Console.WriteLine("fortsätta");
                svar = Console.ReadLine();
            }
        }
    }
}
