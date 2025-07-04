using Raiding.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Heroes
{
    public abstract class BaseHero : IHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }


        public string Name { get; }
        public abstract int Power { get; }

        public abstract string CastAbility();
        protected string CastHealingAbility()
            => $"{GetType().Name} - {Name} healed for {Power}";

        protected string CastHittingAbility()
         => $"{GetType().Name} - {Name} hit for {Power} damage";

    }
}
