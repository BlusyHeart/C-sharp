using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    internal class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        private decimal salary;
        public decimal Salary 
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        private string firstName;
        public string FirstName 
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            } 
        }
        private string lastName;
        public string LastName 
        {
            get
            {
                return lastName;
            } 
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            } 
        }
        private int age;
        public int Age 
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

        public void InreaseSalaray(decimal percentage)
        {
            if (Age < 30)
            {
                percentage /= 2.0M;
            }
            Salary *= 1 + (percentage / 100);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
