using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable
    {
        public List<int> stones { get; set; }

        public Lake(params int[] stones)
        {
            this.stones = new List<int>(stones);
            
        }

        public IEnumerator GetEnumerator()
        {
             return new FrogMoveController(stones);
        }
    }
}
