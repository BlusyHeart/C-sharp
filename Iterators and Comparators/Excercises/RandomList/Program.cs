using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomList
{
    class Program
    {
        static void Main()
        {

            List<string>sdasdasd = new List<string>();
            sdasdasd.Add("1");
            sdasdasd.Add("2");
            sdasdasd.Add("3");
            sdasdasd.Add("4");
            sdasdasd.Add("5");
            
            CustomStack stack = new CustomStack();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(sdasdasd);
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(string.Join(" ", stack));
        }
    }
}

