using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
   

    public class FrogMoveController : IEnumerator
    {
        private List<int> map;

        public FrogMoveController(List<int> map)
        {
            this.map = map;
            current = -1;
        }

        private int current;
        public object Current => current;

        public bool MoveNext()
        {
            current++;
            if (current < map.Count)
            {                
                return true;
            }
            return false;
        }

        public void Reset()
        {
            
        }
    }
}
