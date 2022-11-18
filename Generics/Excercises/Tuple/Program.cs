using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxofString
{
    public class StartUp
    {
        public static void Main()
        {
            PrintTuple1();
            PrintTuple2();
            PrintTuple3();
        }

        private static void PrintTuple3()
        {
            MyTuple<int, double> tuple = CreateTuple3();
            Console.WriteLine(tuple.ToString());
        }

        private static MyTuple<int, double> CreateTuple3()
        {
            string[] input2 = Console.ReadLine().Split();
            int number = int.Parse(input2[0]);
            double secondNumber = double.Parse(input2[1]);
            MyTuple<int, double> tuple = new MyTuple<int, double>(number, secondNumber);
            return tuple;
        }

        private static void PrintTuple2()
        {
            MyTuple<string, int> tuple = CreateTuple2();
            Console.WriteLine(tuple.ToString());
        }

        private static MyTuple<string, int> CreateTuple2()
        {
            string[] input1 = Console.ReadLine().Split();
            string name = input1[0];
            int litersOfBeer = int.Parse(input1[1]);
            MyTuple<string, int> tuple = new MyTuple<string, int>(name, litersOfBeer);
            return tuple;
        }

        private static void PrintTuple1()
        {
            MyTuple<string, string> tuple = CreateTuple1();
            Console.WriteLine(tuple.ToString());
        }

        private static MyTuple<string, string> CreateTuple1()
        {
            string[] input = Console.ReadLine().Split();
            string fullName = $"{input[0]} {input[1]}";
            string city = input[2];
            MyTuple<string, string> tuple = new MyTuple<string, string>(fullName, city);
            return tuple;
        }
    }

}
