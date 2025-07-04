using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models.Contracts
{
    public class FreeDiver : Diver
    {
        private const int _oxygenLevelValue = 120;
        private const double oxyDecreaseIndex = 0.6;
        public FreeDiver(string name)
            : base(name, _oxygenLevelValue)
        {
        }
        public override void Miss(int timeToCatch)
        {
            int usedOxy = (int)Math.Round(timeToCatch * oxyDecreaseIndex);
            base.OxygenLevel -= usedOxy;
        }
        public override void RenewOxy()
        {
            base.OxygenLevel = _oxygenLevelValue;
        }
    }

}
