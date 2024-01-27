using Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.TreeCommands;

public class TreeGoToCommand : ICommand
{
    private readonly SystemNavigate _systemNavigate;
    private readonly Pathway _path;

    public TreeGoToCommand(SystemNavigate systemNavigate, Pathway path)
    {
        ValidatorService.ValidateObjectIfNull(systemNavigate);
        ValidatorService.ValidateObjectIfNull(path);

        _systemNavigate = systemNavigate;
        _path = path;
    }

    public void Execute()
    {
        _systemNavigate.GoToDirectory(_path);
    }
}