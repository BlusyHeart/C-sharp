using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> collection;

        private int currentIndex;

        public ListyIterator(List<T> data)
        {
            currentIndex = 0;
            this.collection = new List<T>(data);
        }

        public void PrintAll()
        {
            Console.WriteLine(String.Join(" ", collection));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                yield return collection[i];
            }
        }

        public bool HasNext() => currentIndex < collection.Count - 1;

        public bool Move()
        {           
            if (HasNext())
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (collection.Count > 0)
            {
                Console.WriteLine(collection[currentIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
