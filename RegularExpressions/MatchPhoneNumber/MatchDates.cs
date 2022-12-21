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
            string pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(phones);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}