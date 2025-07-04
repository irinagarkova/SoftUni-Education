using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Core.Contracts
{
    public class Controller : IController
    {
        private DiverRepository divers  { get; set; }
        private FishRepository fish { get; set; }

        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            IDiver diver = divers.GetModel(diverName);
            if (fish.GetModel(diverName) == null) //проверява дали съшестува такъв водолаз
                return string.Format(OutputMessages.DiverNotFound, nameof(DiverRepository), diverName);

            if (fish.GetModel(fishName) == null)
                return string.Format(OutputMessages.DiverTypeNotPresented, nameof(fishName));

            if (diver.HasHealthIssues)
                return string.Format(OutputMessages.DiverHealthCheck, nameof(diverName));

            IFish currentFish = fish.GetModel(diverName);
            if (diver.OxygenLevel < currentFish.TimeToCatch)
            {
                diver.Miss(currentFish.TimeToCatch);
                if (diver.OxygenLevel == 0)
                {
                    diver.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            else if (diver.OxygenLevel == currentFish.TimeToCatch && !isLucky)
            {
                diver.Miss(currentFish.TimeToCatch);

                if (diver.OxygenLevel == 0)
                {
                    diver.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            else
            {
                diver.Hit(currentFish);

                if (diver.OxygenLevel == 0)
                {
                    diver.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, fishName);
            }
        }

        public string CompetitionStatistics()
        {
            throw new NotImplementedException();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            string result ;

            if (diverType != nameof(FreeDiver) && diverType != nameof(ScubaDiver))
            {
                result = string.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }
            else if (divers.GetModel(diverName) != null)
            {
                result = string.Format(OutputMessages.DiverNameDuplication, diverName, nameof(DiverRepository));
            }
            else
            {
                IDiver diver;

                if (diverType == nameof(FreeDiver))
                {
                    diver = new FreeDiver(diverName);
                }
                else
                {
                    diver = new ScubaDiver(diverName);
                }

                divers.AddModel(diver);
                result = string.Format(OutputMessages.DiverRegistered, diverName, nameof(DiverRepository));
            }

            return result.Trim();
        }

        public string DiverCatchReport(string diverName)
        {
            throw new NotImplementedException();
        }

        public string HealthRecovery()
        {
            throw new NotImplementedException();
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            throw new NotImplementedException();
        }
    }
}
