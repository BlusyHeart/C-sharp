using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animal.Bird
{
    public class Bird : IBird
    {
        public Bird(double wingSize)
        {
            WingSize = wingSize;
        }

        public double WingSize { get ; set ; }
    }
}
