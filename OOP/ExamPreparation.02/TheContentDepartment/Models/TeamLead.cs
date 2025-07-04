using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Utilities.Messages;

namespace TheContentDepartment.Models.Contracts
{
    public class TeamLead : TeamMember
    {
        public TeamLead(string name, string path)
            : base(name, ValidatePath(path))
        {
            
        }

        private static string ValidatePath(string path)
        {
            if (path != "Master")
                throw new ArgumentException(string.Format(ExceptionMessages.PathIncorrect, path));

            return path;
        }
        public override string ToString() =>
            $"{this.Name} ({GetType().Name}) – Currently working on {this.InProgress.Count} tasks.";
        
    }
}
