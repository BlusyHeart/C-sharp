using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        const int COMFORT = 1;
        const decimal PRICE = 5.0m;
        public Ornament() : base(COMFORT, PRICE)
        {
        }
    }
}
