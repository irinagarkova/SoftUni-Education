using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Repositories.Contracts;

namespace TheContentDepartment.Repositories
{
    public class MemberRepository : IRepository<ITeamMember>
    {
        private readonly List<ITeamMember> _models;

        public MemberRepository()
        {
            _models = new List<ITeamMember>();
            this.Models = this._models.AsReadOnly();
        }

        public IReadOnlyCollection<ITeamMember> Models { get; }

        public void Add(ITeamMember model)
        {
            _models.Add(model);
        }

        public ITeamMember TakeOne(string modelName)
        {
            return this.Models.FirstOrDefault(m => m.Name == modelName);
        }

    }
}
