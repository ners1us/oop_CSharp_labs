using System;
using System.Globalization;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.TreeCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SymbolTransmitter;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandHandler;

public class TreeListHandle : BaseCommandHandle
{
    private string? _fileSymbol;
    private string? _folderSymbol;
    private int _indentSpaces;
    public override void Handle(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        if (command.Value.StartsWith("tree list", StringComparison.OrdinalIgnoreCase))
        {
            string[] parts = command.Value.Split(' ');
            ICommand treeListCommand = new TreeListCommand(new Pathway(parts[2]), new Level(int.Parse(parts[4], CultureInfo.InvariantCulture)), new SymbolsTransmit(_fileSymbol, _folderSymbol, _indentSpaces));
            treeListCommand.Execute();
        }
        else
        {
            PassToNextHandler(command);
        }
    }

    public void SetSymbols(string? fileSymbol, string? folderSymbol, int indentSpaces)
    {
        _fileSymbol = fileSymbol;
        _folderSymbol = folderSymbol;
        _indentSpaces = indentSpaces;
    }
}