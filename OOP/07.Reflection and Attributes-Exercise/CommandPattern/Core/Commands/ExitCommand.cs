using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandPattern.Core.Commands
{
    public class ExitCommand : Contracts.ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
