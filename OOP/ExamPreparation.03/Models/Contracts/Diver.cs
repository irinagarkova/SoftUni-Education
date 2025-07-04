using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models.Contracts
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private List<string> _catch = new List<string>();
        private double competitionPoints;
        private bool hasHealthIssues;
        protected Diver(string name, int oxygenLevel)
        {
           
            Name = name;
            OxygenLevel = oxygenLevel;
            _catch = new List<string>();
            competitionPoints = 0;
            hasHealthIssues = false;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException(ExceptionMessages.DiversNameNull);
                name = value;
            }
        }

        public int OxygenLevel
        {
            get => oxygenLevel;
            set
            {
                if (value < 0)
                {
                    oxygenLevel = 0;
                }
                else
                {
                    oxygenLevel = value;
                }
            }
        }

        public IReadOnlyCollection<string> Catch => _catch.AsReadOnly();

        public double CompetitionPoints => Math.Round(competitionPoints, 1);

        public bool HasHealthIssues => hasHealthIssues;

        public void Hit(IFish fish)
        {
            oxygenLevel -= fish.TimeToCatch;
            _catch.Add(fish.Name);
            competitionPoints += fish.Points;
            //competitionPoints += Math.Round(fish.Points, 1, MidpointRounding.AwayFromZero);

        }

        public abstract void Miss(int TimeToCatch);

        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            hasHealthIssues = !hasHealthIssues;
        }

        public override string ToString()
            => $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {Catch.Count}, Points earned: {CompetitionPoints} ]";
    }
}
