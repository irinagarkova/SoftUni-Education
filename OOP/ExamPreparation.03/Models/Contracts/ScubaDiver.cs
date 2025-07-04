using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models.Contracts
{
    public class ScubaDiver : Diver
    {
        private const int _oxygenLevelValue = 540;
        private const double oxyDecreaseIndex = 0.3;
        public ScubaDiver(string name)
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
