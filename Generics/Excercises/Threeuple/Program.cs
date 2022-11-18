using System;
using System.Collections.Generic;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            PrintThreeuple1();
            PrintTuple2();
            PrintTuple3();
        }

        private static void PrintTuple3()
        {
            Threeuple<string, double, string> threeuple = CreateTuple3();
            Console.WriteLine($"{threeuple.Item1} -> {threeuple.Item2} -> {threeuple.Item3}");
        }

        private static Threeuple<string, double, string> CreateTuple3()
        {
            string[] input2 = Console.ReadLine().Split();
            string name = input2[0];
            double bankAccount = double.Parse(input2[1]);
            string bankName = input2[2];
            Threeuple<string, double, string> threeuple = new Threeuple<string, double, string>(name, bankAccount, bankName);
            return threeuple;
        }

        private static void PrintTuple2()
        {
            Threeuple<string, int, string> threeuple = CreateTuple2();
            bool isAbleToDrink = false;
            if (threeuple.Item3 == "drunk")
            {
                isAbleToDrink = true;
                Console.WriteLine($"{threeuple.Item1} -> {threeuple.Item2} -> {isAbleToDrink}");
            }           
            else
            {               
                Console.WriteLine($"{threeuple.Item1} -> {threeuple.Item2} -> {isAbleToDrink}");
            }
        }

        private static Threeuple<string, int, string> CreateTuple2()
        {
            string[] input1 = Console.ReadLine().Split();
            string name = input1[0];
            int age = int.Parse(input1[1]);
            string drinkOrNot = input1[2];
            Threeuple<string, int, string> threeuple = new Threeuple<string, int, string>(name, age, drinkOrNot);
            return threeuple;
        }

        private static void PrintThreeuple1()
        {
            Threeuple<string, string, string> threeuple = CreateThreeuple1();
            Console.WriteLine($"{threeuple.Item1} -> {threeuple.Item2} -> {threeuple.Item3}");
        }

        private static Threeuple<string, string, string> CreateThreeuple1()
        {
            string[] input = Console.ReadLine().Split();
            string fullName = $"{input[0]} {input[1]}";
            string addres = input[2];
            string town = string.Join(" ", input.Skip(3));
            Threeuple<string, string, string> threeuple = new Threeuple<string, string, string>(fullName, addres, town);
            return threeuple;
        }
    }

}
