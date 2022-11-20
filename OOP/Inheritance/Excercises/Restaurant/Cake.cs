using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Cake : Desert
    {
        const double CakeGrams = 250;
        const double CakeCalories = 1000;
        const decimal CakePrice = 5;
        public Cake(string name, decimal price, double grams, double calories) 
            : base(name, CakePrice, CakeGrams, CakeCalories)
        {
            
        }
    }
}
