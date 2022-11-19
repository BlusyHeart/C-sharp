using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
       

        public int Compare(Book item, Book item1)
        {
            int result = item.Title.CompareTo(item.Title);
            if (result == 0)
            {
                return item.Year.CompareTo(item.Year);
            }
            return result;
        }
    }
}
