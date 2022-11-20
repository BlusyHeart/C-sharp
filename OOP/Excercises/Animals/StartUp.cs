using System;
using System.Linq;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Beast!")
                {
                    break;
                }

                string[] animalInfo = Console.ReadLine().Split();
                
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                switch (input)
                {
                    case "Dog":
                        Animal dog = new Dog(name, age, gender);
                        animals.Add(dog);
                        break;

                    case "Cat":
                        Animal cat = new Cat(name, age, gender);
                        animals.Add(cat);
                        break;

                    case "Frog":
                        Animal frog = new Frog(name, age, gender);
                        animals.Add(frog);
                        break;

                    case "Kittens":
                        Animal kitten = new Kittens(name, age);
                        animals.Add(kitten);
                        break;

                    case "Tomcat":
                        Animal tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                        break;
                }
            }
          

        }
    }
}
