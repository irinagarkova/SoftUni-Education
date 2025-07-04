using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var data = args.Split();

            var assembly = Assembly.GetCallingAssembly();
            var commandType = assembly.GetTypes().FirstOrDefault(x => typeof(ICommand).IsAssignableFrom(x) && x.Name.StartsWith(data[0]));
            if (commandType is null) throw new InvalidOperationException("Invalid command");

            var commandObj = Activator.CreateInstance(commandType);
            if (commandObj is ICommand command) return command.Execute(data[1..]);

            return string.Empty;
        }
    }
}
