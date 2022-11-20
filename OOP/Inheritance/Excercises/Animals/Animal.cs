using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    internal class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        private string name;
        private int age;
        private string gender;

        public string Name 
        {
            get
            {
                return Name;
            }
            set
            {
                if (!char.IsUpper(value[0]) && !value.Any(x => char.IsLetter(x)))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public int Age 
        {
            get
            {
                return Age;
            }
            set
            {
                if (Age < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            } 
        }

        public string Gender 
        {
            get
            {
                return Gender;
            }
            set
            {
                if (value != "Male" || value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            } 
        }

        public virtual void ProduceSound()
        {

        }

    }
}
