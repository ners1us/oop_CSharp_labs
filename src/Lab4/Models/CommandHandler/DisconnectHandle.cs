using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.SystemCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class DisconnectHandle : BaseCommandHandle
{
    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("disconnect", StringComparison.OrdinalIgnoreCase))
        {
            ICommand disconnectCommand = new SystemDisconnectCommand();
            disconnectCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }
}
