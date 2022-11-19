using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public partial class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int resullt = Year.CompareTo(other.Year);
            if (resullt == 0)
            {
                return Title.CompareTo(other.Title);
            }
            return resullt;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
