using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Repositories
{
    public class FishRepository : IRepository<IFish>
    {
        private readonly List<IFish> _fish;
        public IReadOnlyCollection<IFish> Models => _fish;

        public void AddModel(IFish model) => _fish.Add(model);

        public IFish GetModel(string name) => Models.FirstOrDefault(x => x.Name == name);
    }
}
