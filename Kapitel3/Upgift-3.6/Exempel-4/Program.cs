using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //läas in email

            Console.Write("Ange email: ");
            string email = Console.ReadLine();


            //leta efter ett täcken i texten

            int position = email.IndexOf("@");

            string namn = email.Substring(0, position);
            Console.WriteLine("Hej " + namn);

            //plocka domänet fron p till slut
            string doman = email.Substring(position + 1);
            Console.WriteLine("doman " + doman);



        }
    }
}
