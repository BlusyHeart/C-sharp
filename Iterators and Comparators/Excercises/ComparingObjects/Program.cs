using System;
using System.Linq;
using System.Collections.Generic;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            List<Person> list = new List<Person>(); 
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0]== "END")
                {
                    break;
                }

                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                Person person = new Person(name, age, town);
                list.Add(person);
            }
            int index = int.Parse(Console.ReadLine());

            Person comparablePerson = list[index - 1];
            int countMatches = 0;
            int countNotMatches = 0;
           
            foreach (Person Person in list)
            {
                int result =  Person.CompareTo(comparablePerson);
                if (result == 0)
                {
                    countMatches++;
                }
                else
                {
                    countNotMatches++;
                }
            }

            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {countNotMatches} {list.Count}");
            }
        }
    }
}
