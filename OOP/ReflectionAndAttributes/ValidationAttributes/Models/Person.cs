using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private const int _AgeMinValue = 12;
        private const int _AgeMaxValue = 90;

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        [MyReqired]
        public string FullName { get; private set; }

        [MyRange(_AgeMinValue, _AgeMaxValue)]
        public int Age { get; private set; }

    }
}
