using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{ 
    class StartUp
    {
        public static void Main()
        {

            Box<int> box = new Box<int>();
            box.Add(20);
            box.Add(40);
            int element = box.Remove();
            Console.WriteLine(element);


        }
    }

}
