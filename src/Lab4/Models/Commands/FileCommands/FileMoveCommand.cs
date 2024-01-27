using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;

public class FileMoveCommand : ICommand
{
    private readonly Pathway _sourcePath;
    private readonly Pathway _destinationPath;

    public FileMoveCommand(
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
            File.Move(_sourcePath.Value, _destinationPath.Value);
        }
        catch (FileNotFoundException ex)
        {
            throw new NoFileFoundException(ex.Message);
        }
    }
}