﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Commands
{
    public class HelloCommand : Contracts.ICommand
    {
        public string Execute(string[] args)
        {
            if (args.Length != 1) throw new InvalidOperationException("A single argument is required for the \"Hello\" command");
            return $"Hello, {args[0]}";
        }
    }
}
