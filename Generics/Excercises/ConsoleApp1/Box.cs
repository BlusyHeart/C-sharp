using System.Collections.Generic;


namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            BoxList = new List<T>();
        }

        public List<T> BoxList { get; set; }

        public int Count { get; }

        public void Add(T element)
        {
            BoxList.Add(element);
        }

        public T Remove()
        {
            T element = BoxList[BoxList.Count - 1];
            BoxList.RemoveAt(BoxList.Count - 1);
            return element;
        }
    }
}
