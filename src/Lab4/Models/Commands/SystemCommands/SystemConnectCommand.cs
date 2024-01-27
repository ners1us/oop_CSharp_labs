using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.SystemCommands;

public class SystemConnectCommand : ICommand
{
    private static readonly Pathway CurrentPathValue = new(Environment.CurrentDirectory);
    private readonly Pathway _connectingPath;
    private Pathway _currentPath;

    public SystemConnectCommand(Pathway connectingPath)
    {
        ValidatorService.ValidateObjectIfNull(connectingPath);

        _currentPath = CurrentPathValue;
        _connectingPath = connectingPath;
    }

    public void Execute()
    {
        _currentPath = _connectingPath;
        Console.WriteLine("Connected to the file system");
    }
}