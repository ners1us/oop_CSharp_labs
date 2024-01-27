using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;

public class FileDeleteCommand : ICommand
{
    private readonly Pathway _path;

    public FileDeleteCommand(Pathway path)
    {
        ValidatorService.ValidateObjectIfNull(path);

        _path = path;
    }

    public void Execute()
    {
        try
        {
            File.Delete(_path.Value);
        }
        catch (FileNotFoundException ex)
        {
            throw new NoFileFoundException(ex.Message);
        }
    }
}