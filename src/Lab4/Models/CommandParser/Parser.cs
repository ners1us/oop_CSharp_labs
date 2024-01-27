using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;
using Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandParser;

public class Parser : IParser
{
    private readonly ICommandHandle _commandHandler;
    private readonly ConnectHandle _connectHandle = new();
    private readonly DisconnectHandle _disconnectHandle = new();
    private readonly FileCopyHandle _fileCopyHandle = new();
    private readonly FileDeleteHandle _fileDeleteHandle = new();
    private readonly FileMoveHandle _fileMoveHandle = new();
    private readonly FileRenameHandle _fileRenameHandle = new();
    private readonly FileShowHandle _fileShowHandle = new(new FileView());
    private readonly TreeListHandle _treeListHandle = new();
    private readonly TreeGoToHandle _treeGoToHandle = new(new SystemNavigate(new Pathway(Environment.CurrentDirectory)));

    public Parser()
    {
        _commandHandler = _connectHandle;
        _commandHandler.SetNext(_disconnectHandle)
            .SetNext(_fileCopyHandle)
            .SetNext(_fileDeleteHandle)
            .SetNext(_fileMoveHandle)
            .SetNext(_fileRenameHandle)
            .SetNext(_fileShowHandle)
            .SetNext(_treeListHandle)
            .SetNext(_treeGoToHandle);
    }

    public void ParseCommand(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        _commandHandler.Handle(command);
    }

    public void ReceiveTreeListCommandSymbols(string? fileSymbol, string? folderSymbol, int indentSpaces)
    {
        _treeListHandle.SetSymbols(fileSymbol, folderSymbol, indentSpaces);
    }
}