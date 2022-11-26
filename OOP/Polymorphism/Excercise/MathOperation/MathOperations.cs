using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    internal class MathOperations
    {
        

        public int Add(int value, int value1)
        {
            return value + value1;
        }

        public double Add(double value, double value1, double value2)
        {
            return (value1 + value2) / 2;
        }

        public decimal Add(decimal value, decimal value1, decimal value2)
        {
            return value + value1 + value2;
        }
    }
}
