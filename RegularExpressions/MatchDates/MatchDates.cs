using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regex_Training
{
    class StartUp
    {
        static void Main()
        {
            string pattern = @"(?<day>\d{2})([.|/|-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string dates = Console.ReadLine();   

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(dates);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }  
}
