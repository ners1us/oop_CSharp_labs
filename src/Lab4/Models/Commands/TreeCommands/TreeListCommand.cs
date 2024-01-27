using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SymbolTransmitter;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.TreeCommands;

public class TreeListCommand : ICommand
{
    private readonly Pathway _path;
    private readonly Level _depth;
    private readonly string? _folderSymbol;
    private readonly string? _fileSymbol;
    private readonly int _indentSpaces;

    public TreeListCommand(
        Pathway path,
        Level depth,
        SymbolsTransmit symbolsTransmit)
    {
        ValidatorService.ValidateObjectIfNull(path);
        ValidatorService.ValidateObjectIfNull(depth);

        _path = path;
        _depth = depth;
        SymbolsTransmit = symbolsTransmit;
        _folderSymbol = SymbolsTransmit.FolderSign;
        _fileSymbol = SymbolsTransmit.FileSign;
        _indentSpaces = SymbolsTransmit.IndentSpaces;
    }

    public SymbolsTransmit SymbolsTransmit { get; private set; }

    public void Execute()
    {
        DisplayDirectoryTree(_path.Value, _depth.Value);
    }

    private void DisplayDirectoryTree(string path, int depth)
    {
        DisplayDirectoryTreeRecursive(new DirectoryInfo(path), 1, depth);
    }

    private void DisplayDirectoryTreeRecursive(DirectoryInfo directory, int currentDepth, int targetDepth)
    {
        if (currentDepth > targetDepth)
        {
            return;
        }

        Console.WriteLine(new string(' ', (currentDepth - 1) * _indentSpaces) + _folderSymbol + directory.Name);

        foreach (FileInfo file in directory.GetFiles())
        {
            Console.WriteLine(new string(' ', currentDepth * _indentSpaces) + _fileSymbol + file.Name);
        }

        foreach (DirectoryInfo subdirectory in directory.GetDirectories())
        {
            DisplayDirectoryTreeRecursive(subdirectory, currentDepth + 1, targetDepth);
        }
    }
}