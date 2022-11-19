using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance.Animal
{
    public class StartUp
    {
        static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}

