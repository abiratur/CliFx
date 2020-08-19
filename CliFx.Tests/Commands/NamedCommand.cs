﻿using System.Threading.Tasks;
using CliFx.Attributes;

namespace CliFx.Tests.Commands
{
    [Command("named", Description = nameof(NamedCommand))]
    public class NamedCommand : ICommand
    {
        public const string ExpectedOutputText = nameof(NamedCommand);

        public ValueTask ExecuteAsync(IConsole console)
        {
            console.Output.WriteLine(ExpectedOutputText);
            return default;
        }
    }
}