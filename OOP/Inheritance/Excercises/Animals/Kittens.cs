using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    internal class Kittens : Cat
    {
        public Kittens(string name, int age) : base(name, age, "Female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
