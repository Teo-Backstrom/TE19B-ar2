using System;

namespace exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa en array tre städers namn "stockholm" "PARIS" " London"
            string[] städer = { "Stockholm", "Paris", "London" };

            // Skriver ut innehållet
            Console.WriteLine(städer[0]);


            //alternativ 2 : Skapa en tom array på 2 strings
            string[] länder = new string[2];

            //Skapa en annan array av 3 tal
            int[] årtal = new int[3];

            //Fylla en array
            länder[0] = "FRANKRIKE";
            länder[1] = "SVERIGE";

            årtal[1] = 1200;
            årtal[2] = 1300;
            årtal[3] = 1400;
        }

    }
}
