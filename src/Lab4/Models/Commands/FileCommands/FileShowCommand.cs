using Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;

public class FileShowCommand : ICommand
{
    private readonly Pathway _path;
    private readonly IFileView _fileView;

    public FileShowCommand(
        Pathway path,
        IFileView fileView)
    {
        ValidatorService.ValidateObjectIfNull(path);
        ValidatorService.ValidateObjectIfNull(fileView);

        _path = path;
        _fileView = fileView;
    }

    public void Execute()
    {
        _fileView.ShowFile(_path);
    }
}