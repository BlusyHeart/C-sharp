using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.Books = new List<Book>();
        }

        public List<Book> Books { get; set; }

        public void Add(Book book)
        {
            Books.Add(book);
        }

        public void Remove(Book book)
        {
            Books.Remove(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                yield return Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
