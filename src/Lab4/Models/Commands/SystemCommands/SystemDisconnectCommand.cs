using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.SystemCommands;

public class SystemDisconnectCommand : ICommand
{
    private static readonly Pathway RootPath = new(Environment.CurrentDirectory);
    private Pathway? _currentPath;

    public void Execute()
    {
        _currentPath = RootPath;
        Console.WriteLine("Disconnected from the file system");
    }
}