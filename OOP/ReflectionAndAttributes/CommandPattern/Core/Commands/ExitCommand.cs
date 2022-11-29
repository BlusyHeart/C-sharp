using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Commands
{
    public class ExitCommand : ICommand
    {
        private const int SuccesExitCode = 0;
        public string Execute(string[] args)
        {
            Environment.Exit(1);
            return null;
        }
    }
}
