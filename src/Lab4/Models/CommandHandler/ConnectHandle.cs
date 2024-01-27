using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.SystemCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class ConnectHandle : BaseCommandHandle
{
    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("connect", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = command.Value.Split(' ');
            ICommand connectCommand = new SystemConnectCommand(new Pathway(parts[1]));
            connectCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }
}