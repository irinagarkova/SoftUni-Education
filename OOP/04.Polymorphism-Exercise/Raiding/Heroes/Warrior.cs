﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Heroes
{
  public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
        }
        public override int Power => 100;

        public override string CastAbility() => CastHittingAbility();
   }
}

