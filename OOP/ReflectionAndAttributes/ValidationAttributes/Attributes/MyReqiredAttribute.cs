using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace ValidationAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    internal class MyReqiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            if (obj is string str)
            {
                return String.IsNullOrEmpty(str);
            }

            return obj != null;
        }
    }
}
