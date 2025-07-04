using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Utilities.Messages;

namespace TheContentDepartment.Models
{
    public class ContentMember : TeamMember
    {
        public ContentMember(string name, string path)
            : base(name, ValidatePath(path))
        {

           // if (path != "CSarp" && path!= "JavaScript" && path != "Python" && path != "Java")
               // throw new ArgumentException(string.Format(ExceptionMessages.PathIncorrect, path));

        }
        private static string ValidatePath(string path)
        {
            if (path != "CSarp" && path != "JavaScript" && path != "Python" && path != "Java")
                throw new ArgumentException(string.Format(ExceptionMessages.PathIncorrect, path));

            return path;
        }
        public override string ToString()
            => $"{Name} - {Path} path. Currently working on {this.InProgress.Count} tasks.";
      
    }
}
