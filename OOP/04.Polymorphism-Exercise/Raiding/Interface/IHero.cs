﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Interface
{
    public interface IHero
    {
        string Name { get; }
        int Power { get; }

        string CastAbility();
    }
}
