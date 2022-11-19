using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    internal class CustomStack : Stack<string>
    {
            
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(IEnumerable<string> items)
        {
            foreach (string word in items)
            {
                Push(word);
            }  
        }
    }
}
