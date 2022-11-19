using System.Collections;

namespace IteratorsAndComparators
{
    public class Enumarator : IEnumerator<Book>
    {
        private List<Book> books;

        private int currentIndex;

        public Enumarator(List<Book> books)
        {
            this.books = books;
            this.currentIndex = -1;
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {

        }
    }
}
