using CommandPattern.Core.Contracts;
using CommandPattern.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    internal class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string line)
        {
            string[] lineSplit = line.Split();

            string commandName = lineSplit[0];
            string[] commandArguments = lineSplit.Skip(1).ToArray();

            Assembly assembly = Assembly.GetEntryAssembly();
            Type cmdType = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandName}Command"
                && t.GetInterfaces().Any(i => i == typeof(ICommand)));

            if (cmdType == null)
            {
                throw new InvalidOperationException();
            }

            object cmdInstance = Activator.CreateInstance(cmdType);

            MethodInfo executeMethod = cmdType
                .GetMethods()
                .FirstOrDefault(m => m.Name == "Execute");

            string result = (string)executeMethod.Invoke(cmdInstance, new object[] { commandArguments });

            return result;


        }
    }
}
