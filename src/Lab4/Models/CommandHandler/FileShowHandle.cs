using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class FileShowHandle : BaseCommandHandle
{
    private readonly IFileView _fileView;

    public FileShowHandle(IFileView fileView)
    {
        ValidatorService.ValidateObjectIfNull(fileView);

        _fileView = fileView;
    }

    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("file show", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = command.Value.Split(' ');
            ICommand fileShowCommand = new FileShowCommand(new Pathway(parts[2]), _fileView);
            fileShowCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }
}