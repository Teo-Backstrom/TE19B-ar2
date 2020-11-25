using System;

namespace morsemorse
{
    class Program
    {
        static void Main(string[] args)
        {

            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";

            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

            Console.WriteLine("Prorammet översätter string till morse skriv en bokstav efter den anddra med enter mellan varje bokstav");
            Console.WriteLine("skriv bokstav");

            string meddelande = Console.ReadLine();
            meddelande = meddelande.ToUpper();



            for (int i = 0; i < meddelande.Length; i++)
            {
                string bokstav = meddelande[i].ToString();
                int index = alfabetet.IndexOf(bokstav);
                Console.Write(morse[index]);
            }


        }
    }
}
