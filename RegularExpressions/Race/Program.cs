using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Regex_Training
{
    class StartUp
    {
        static void Main()
        {

            List<string> listOfRacers = Console.ReadLine().Split(", ").ToList();

            string namePattern = @"[a-zA-Z]";
            string digitsPattern = @"\d";

            Regex nameRegex = new Regex(namePattern);
            Regex digits = new Regex(digitsPattern);

            Dictionary<string, int> racers = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {

                MatchCollection matches = nameRegex.Matches(input);
                string name = string.Empty;

                if (matches.Any())
                {
                    name = string.Join("", matches);
                }

                matches = digits.Matches(input);
                int sum = 0;
                if (matches.Any())
                {
                    sum = matches.Select(m => int.Parse(m.Value)).Sum();
                }

                if (listOfRacers.Contains(name))
                {
                    if (!racers.ContainsKey(name))
                    {
                        racers.Add(name, 0);
                    }
                    racers[name] += sum;
                }

                input = Console.ReadLine();
            }

            List<string> sortedRacers =
                racers.OrderByDescending(r => r.Value).Select(x => x.Key).Take(3).ToList();

            int place = 1;
            int index = 0;

            Console.WriteLine($"{place++}st place: {sortedRacers[index++]}");
            Console.WriteLine($"{place++}nd place: {sortedRacers[index++]}");
            Console.WriteLine($"{place++}rd place: {sortedRacers[index++]}");


        }
    }
}
