using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTestFiles
{

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\github\Te19B-ar2\labbar\DataAccessTestFiles\Test.txt";
            /*
                List<string> lines = File.ReadAllLines(filePath).ToList();

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }

                lines.Add("sue,storm,www.stormy.com");

                File.WriteAllLines(filePath, lines); */
            //göra en lista
            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();
                //För varje rad så splittar man vid "," och lägger in det i en array
                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
            }

            //skriver ut allt i ordning
            Console.WriteLine("Read from text file");
            foreach (var person in people)
            {
                Console.WriteLine("${person.Firstname} {person.Lastname}: {person.Url}");
            }

            people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.greg" });

            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add($"{ person.FirstName}, { person.LastName},{ person.Url}");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();
        }
    }
}
