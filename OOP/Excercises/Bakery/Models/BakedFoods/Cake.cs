﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        private const int INITIAL_BREAD_PORTION = 245;

        public Cake(string name, decimal price) : base(name, INITIAL_BREAD_PORTION, price)
        {
        }
    }
}
