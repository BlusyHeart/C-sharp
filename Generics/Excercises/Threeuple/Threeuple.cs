using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class Threeuple<T, T1, T2> where T1 : IComparable
    {
        public Threeuple(T item1, T1 item2, T2 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public T Item1 { get; set; }

        public T1 Item2 { get; set; }

        public T2 Item3 { get; set; }      
        
    }
}
