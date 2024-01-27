using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.TreeCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class TreeGoToHandle : BaseCommandHandle
{
    private readonly SystemNavigate _systemNavigate;

    public TreeGoToHandle(SystemNavigate systemNavigate)
    {
        _systemNavigate = systemNavigate;
    }

    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("tree goto", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = command.Value.Split(' ');
            ICommand fileMoveCommand = new TreeGoToCommand(_systemNavigate, new Pathway(parts[2]));
            fileMoveCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }
}