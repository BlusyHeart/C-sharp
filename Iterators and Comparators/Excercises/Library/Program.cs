using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main()
        {

            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryTwo = new Library()
            {
                bookTwo, bookOne, bookThree
            };
            libraryTwo.Sort();

            foreach (var book in libraryTwo)
            {                
                Console.WriteLine(book);
            }
        }
    }
}
