﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Fish : MainDish
    {
        const double FishGrams = 22;
        public Fish(string name, decimal price, double grams) : base(name, price, FishGrams)
        {
        }
    }
}
