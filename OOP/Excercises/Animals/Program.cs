using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class StartUp
    {
        static void Main()
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
