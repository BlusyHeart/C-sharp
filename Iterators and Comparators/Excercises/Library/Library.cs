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
        public Library()
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

        public BookComparator Sort()
        {
            for (int index = 0; index < Books.Count; index++)
            {
                return new BookComparator(Books[index], Books[index + 1]);
            }
            return null;
        }
       
        public IEnumerator<Book> GetEnumerator()
        {
            return new Enumarator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}
