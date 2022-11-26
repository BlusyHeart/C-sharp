using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    internal class Paladin : BaseHero
    {
        const int PALADIN_POWER = 100;
        public Paladin(string name) : base(name, PALADIN_POWER)
        {
        }
    }
}
