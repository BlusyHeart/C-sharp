using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int index = 0; index < numberOfMembers; index++)
            {
                string[] memberInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = memberInfo[0];
                int age = int.Parse(memberInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
               
            }

            List<Person> filteredMembers = family.GetOlderThen30Years();
            List<Person> sortedMembers = filteredMembers.OrderBy(member => member.Name).ToList();
            family.PrintMember(sortedMembers);

        }

    }
}



