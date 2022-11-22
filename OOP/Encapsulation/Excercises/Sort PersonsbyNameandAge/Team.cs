using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    internal class Team
    {
        public Team(string name)
        {
            Name = name;
            this.firstTeam = new List<Person>();
            this.secondTeam = new List<Person>();
        }

        private List<Person> firstTeam;

        private List<Person> secondTeam;
        public string Name { get; private set; }

        public IReadOnlyCollection<Person> SecondTeam => this.secondTeam;

        public IReadOnlyCollection<Person> FirstTeam => this.firstTeam;

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                secondTeam.Add(person);
            }
        }
    }
}
