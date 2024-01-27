using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class FileDeleteHandle : BaseCommandHandle
{
    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("file delete", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = command.Value.Split(' ');
            ICommand fileDeleteCommand = new FileDeleteCommand(new Pathway(parts[2]));
            fileDeleteCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }
}