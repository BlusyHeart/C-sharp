using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        const int WARRIOR_POWER = 100;

        public Warrior(string name) : base(name, WARRIOR_POWER)
        {
        }
    }
}
