using System.Globalization;
using Itmo.ObjectOrientedProgramming.Lab4.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.SystemCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.TreeCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SymbolTransmitter;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.CommandFactory;

public class MockCommandFactory : IMockCommandFactory
{
    private const string FileSymbolForTreeList = "-";
    private const string FolderSymbolForTreeList = "+";
    private const int IndentSpaces = 2;
    private readonly IFileView _fileView;
    private readonly SystemNavigate _systemNavigate;

    public MockCommandFactory(
        IFileView fileView,
        SystemNavigate systemNavigate)
    {
        _fileView = fileView;
        _systemNavigate = systemNavigate;
    }

    public ICommand Create(Text action, string[] parts)
    {
        ValidatorService.ValidateObjectIfNull(parts);
        ValidatorService.ValidateObjectIfNull(action);

        return action.Value switch
        {
            "connect" => new SystemConnectCommand(new Pathway(parts[1])),
            "disconnect" => new SystemDisconnectCommand(),
            "show" => new FileShowCommand(new Pathway(parts[2]), _fileView),
            "move" => new FileMoveCommand(new Pathway(parts[2]), new Pathway(parts[3])),
            "rename" => new FileRenameCommand(new Pathway(parts[2]), new Pathway(parts[3])),
            "copy" => new FileCopyCommand(new Pathway(parts[2]), new Pathway(parts[3])),
            "delete" => new FileDeleteCommand(new Pathway(parts[2])),
            "goto" => new TreeGoToCommand(_systemNavigate, new Pathway(parts[2])),
            "list" => new TreeListCommand(new Pathway(parts[2]), new Level(int.Parse(parts[4], CultureInfo.InvariantCulture)), new SymbolsTransmit(FileSymbolForTreeList, FolderSymbolForTreeList, IndentSpaces)),
            _ => throw new UnknownCommandException("Unknown action"),
        };
    }
}
