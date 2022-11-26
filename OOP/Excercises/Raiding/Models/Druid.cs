using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        const int DRUID_POWER = 80;

        public Druid(string name) : base(name, DRUID_POWER)
        {

        }


    }
}
