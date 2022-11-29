using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] properties = type
                .GetProperties()
                .Where(pi => pi.CustomAttributes
                .Any(a => a.AttributeType.BaseType == typeof(MyValidationAttribute)))
                .ToArray();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);    

                foreach (CustomAttributeData dataAttr in property.CustomAttributes)
                {
                    Type customAttrType = dataAttr.AttributeType;
                    object attributeInstance = property
                        .GetCustomAttribute(customAttrType);
                       
                    MethodInfo validationMethod = customAttrType
                        .GetMethods()
                        .First(m => m.Name == "IsValid");
                    
                    bool result = (bool)validationMethod.Invoke(attributeInstance, new object[] { value });
                    if (result)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
