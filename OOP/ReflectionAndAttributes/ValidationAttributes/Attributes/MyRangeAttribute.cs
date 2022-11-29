using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ValidationAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    internal class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int _min;
        private readonly int _max;

        public MyRangeAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public override bool IsValid(object obj)
        {

            if (obj is int val)
            {
                
                return val >= _min && val <= _max;
            }

            return false;
        }
    }
}
