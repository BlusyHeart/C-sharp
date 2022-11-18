using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
    {
        public Box()
        {
            DataStorage = new List<T>();
        }

        public List<T> DataStorage { get; set; }

        public void Add(T element)
        {
            DataStorage.Add(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = DataStorage[firstIndex];
            DataStorage[firstIndex] = DataStorage[secondIndex];
            DataStorage[secondIndex] = temp;
        }

        public override string ToString()
        {
          StringBuilder stringBuilder = new StringBuilder();

            foreach (T item in DataStorage)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
