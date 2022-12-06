using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public class FreshwaterAquarium : Aquarium
    {
        const int CAPACITY = 50;
        public FreshwaterAquarium(string name) : base(name, CAPACITY)
        {
        }
    }
}
