using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main()
        {

            Book bookOne = new Book("Animal Farm", 2003);
            Book bookTwo = new Book("Animal Farm", 2003);
            Book bookThree = new Book("Animal Farm", 2003);
            Book bookFour = new Book("Animal Farm", 2003);

            List<Book> books = new List<Book>();
            Library libraryOne = new Library();
            libraryOne.Add(bookOne);
            libraryOne.Add(bookTwo);
            libraryOne.Add(bookThree);
            libraryOne.Add(bookFour);

            foreach (Book book in libraryOne)
            {
                Console.WriteLine(book.Year);
            }
        }
    }
}
