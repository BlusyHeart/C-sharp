﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Interfaces
{
    internal interface IBaseHero
    {
        public string Name { get; }

        public int Power { get; }

        string CastAbility();
    }
}
