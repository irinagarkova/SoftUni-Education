﻿using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Repositories
{
    public class InfluencerRepository : IRepository<IInfluencer>
    {
        private readonly List<IInfluencer> models = new();

        public IReadOnlyCollection<IInfluencer> Models => models.AsReadOnly();

        public void AddModel(IInfluencer model)
        {
            models.Add(model);
        }

        public IInfluencer FindByName(string name)
        {
            return models.FirstOrDefault(m => m.Username == name);
        }

        public bool RemoveModel(IInfluencer model)
        {
            return models.Remove(model);
        }
    }
}
