using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class MyStack<T> : IEnumerable<T> 
    {
        private List<T> collection;

        public MyStack()
        {
            this.collection = new List<T>();
        }

        public void Push(T item) => collection.Add(item);
       
        public T Pop()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T element = collection.Last();
            collection.RemoveAt(collection.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int index = collection.Count - 1; index >= 0; index--)
            {
                yield return collection[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
