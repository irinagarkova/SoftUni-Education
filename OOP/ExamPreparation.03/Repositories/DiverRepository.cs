﻿using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Repositories
{
    public class DiverRepository : IRepository<IDiver>
    {
        private readonly List<IDiver> divers;
        public IReadOnlyCollection<IDiver> Models => divers;

        public void AddModel(IDiver model)
        {
            divers.Add(model);
        }

        public IDiver GetModel(string name) => Models.FirstOrDefault(x => x.Name == name);
    }
}
