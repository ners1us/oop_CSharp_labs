using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;

public class FileRenameCommand : ICommand
{
    private readonly Pathway _path;
    private readonly Pathway _newName;

    public FileRenameCommand(
        Pathway path,
        Pathway newName)
    {
        ValidatorService.ValidateObjectIfNull(path);
        ValidatorService.ValidateObjectIfNull(newName);

        _path = path;
        _newName = newName;
    }

    public void Execute()
    {
        string? gotDirectoryName = Path.GetDirectoryName(_path.Value);

        ArgumentNullException.ThrowIfNull(gotDirectoryName);

        string destinationFileName = Path.Combine(gotDirectoryName, _newName.Value);
        File.Move(_path.Value, destinationFileName);
    }
}