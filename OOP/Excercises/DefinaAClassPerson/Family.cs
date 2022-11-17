using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers { get; set; }
        
        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }

        public Person GetOldestMember() => FamilyMembers.OrderByDescending(person => person.Age).FirstOrDefault();

        public List<Person> GetOlderThen30Years()
        {
            Predicate<Person> predicate = member => member.Age > 30;
            List<Person> filterFamalyMembers = FamilyMembers.Where(member => predicate(member)).ToList();
            return filterFamalyMembers;
        }
        public void PrintMember(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
