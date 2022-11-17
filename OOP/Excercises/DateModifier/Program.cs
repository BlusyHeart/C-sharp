using System;
using System.Linq;
using System.Collections.Generic;

namespace DateModifier
{
    public class StartUp
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.DifferenceInDays(firstDate, secondDate);

            Console.WriteLine(days);

        }
    }
}
