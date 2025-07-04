using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Utilities.Messages;

namespace TheContentDepartment.Models
{
    public abstract class TeamMember : ITeamMember
    {
        private readonly List<string> _inProgress = new List<string>();
        protected TeamMember(string name, string path)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(ExceptionMessages.NameNullOrWhiteSpace);

            this.Name = name;
            this.Path = path;
        }

        public string Name { get; }
        public string Path { get; }

        public IReadOnlyCollection<string> InProgress => this._inProgress.AsReadOnly();

        public void FinishTask(string resourceName)
        {
            this._inProgress.Remove(resourceName);
        }

        public void WorkOnTask(string resourceName)
        {
            this._inProgress.Add(resourceName);
        }
    }
}
