using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class FileRenameHandle : BaseCommandHandle
{
    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("file rename", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = command.Value.Split(' ');
            ICommand fileRenameCommand = new FileRenameCommand(new Pathway(parts[2]), new Pathway(parts[3]));
            fileRenameCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }
}