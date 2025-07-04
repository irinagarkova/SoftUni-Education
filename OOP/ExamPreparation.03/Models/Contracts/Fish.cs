using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models.Contracts
{
    public abstract class Fish :IFish
    {
        protected Fish(string name, double points)
        {
            Name = name;
            Points = points;
        }

        protected Fish(string name, double points, int timeToCatch)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(ExceptionMessages.FishNameNull);
            if(points >1 && points <10)
                throw new ArgumentException(ExceptionMessages.PointsNotInRange);

            Name = name;
            Points = points;
            TimeToCatch = timeToCatch;
        }

        public string Name { get; private set; }

        public double Points { get; private set; }

        public int TimeToCatch { get; private set; }

        public override string ToString() =>
            $"{GetType().Name}: {Name} [ Points: {Points}, Time to Catch: {TimeToCatch} seconds ]";
    }
}
