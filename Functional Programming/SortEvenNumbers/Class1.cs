using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenNumbers
{
    class Class1
    {

       


        private static List<int> MySelect(IEnumerable<int> numbers, Func<int, int> selector)
        {
            List<int> ints = new List<int>();
            foreach (int item in numbers)
            {
                ints.Add(selector(item));
            }
            return ints;
        }

        static List<int> MyWhere(List<int> numbers, Func<int, bool> filter)
        {
            List<int> ints = new List<int>();
            foreach (int item in numbers)
            {
                if (filter(item))
                {
                    ints.Add(item);
                }
            }
            return ints;
        }



    }
}
