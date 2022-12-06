using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        const int COMFORT = 5;
        const decimal PRICE = 10.0m;
        public Plant() : base(COMFORT, PRICE)
        {
        }
    }
}
