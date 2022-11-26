using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Factories.Interfaces
{
    public interface IHeroFactory
    {
        BaseHero CreateHero(string name, string heroType);
    }
}
