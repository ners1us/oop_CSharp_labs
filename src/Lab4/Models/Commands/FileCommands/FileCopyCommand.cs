using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;

public class FileCopyCommand : ICommand
{
    private readonly Pathway _sourcePath;
    private readonly Pathway _destinationPath;

    public FileCopyCommand(
        Pathway sourcePath,
        Pathway destinationPath)
    {
        ValidatorService.ValidateObjectIfNull(sourcePath);
        ValidatorService.ValidateObjectIfNull(destinationPath);

        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
    }

    public void Execute()
    {
        try
        {
            File.Copy(_sourcePath.Value, _destinationPath.Value);
        }
        catch (IOException ex)
        {
            throw new FileAlreadyExistsException(ex.Message);
        }
    }
}