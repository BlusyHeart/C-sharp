using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    internal class Coffee : Beverage
    {
        const double CoffeMilliliters = 50;
        const decimal CoffePrice = 3.50M;

        public Coffee(string name, decimal price, double caffeine) 
            : base(name, CoffePrice, CoffeMilliliters)
        {           
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
