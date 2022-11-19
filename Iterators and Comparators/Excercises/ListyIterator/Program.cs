using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main()
        {
            ListyIterator<string> listy = null;
            while (true)
            {

                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] commandArguments = input.Split().ToArray();
                string command = commandArguments[0];

                switch (command)
                {
                    case "Create":
                        List<string> iteratorArguments = commandArguments.Skip(1).ToList();
                        listy = new ListyIterator<string>(iteratorArguments);
                        break;
                    case "Print":
                        listy.Print();
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "PrintAll":
                        listy.PrintAll();
                        break;
                }
            }
        }
    }
}
