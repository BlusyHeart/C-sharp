using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        const int ROGUE_POWER = 80;

        public Rogue(string name) : base(name, ROGUE_POWER)
        {
        }
    }
}
