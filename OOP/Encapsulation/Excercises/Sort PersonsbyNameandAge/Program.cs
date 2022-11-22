using System;
using System.Linq;
using System.Collections.Generic;
using PersonsInfo;

namespace PersonsInfo
{
    class StartUp
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();
            AddPerson(numberOfInputs, persons);

            /*List<Person> sortedPersons = persons.OrderBy(person => person.FirstName)
                .ThenBy(person => person.Age)
                .ToList();*/

            /*int percentage = int.Parse(Console.ReadLine());
            persons.ForEach(person => person.InreaseSalaray(percentage));*/

            Team team = new Team("SoftUni");
            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }
            PrintPerson(persons);
           
            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.SecondTeam.Count);
        }

        private static void PrintPerson(List<Person> sortedPersons)
        {
            foreach (Person person in sortedPersons)
            {
                Console.WriteLine(person);
            }
        }

        private static void AddPerson(int numberOfInputs, List<Person> persons)
        {
            for (int index = 0; index < numberOfInputs; index++)
            {
                string[] input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                decimal salary = decimal.Parse(input[3]);

                Person person = new Person(firstName, lastName, age, salary);
                persons.Add(person);
            }
        }
    }
}
