using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.CommandFactory;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.CommandParser;

public class MockParser : IMockParser
{
    private readonly IMockCommandFactory _mockCommandFactory;
    private readonly SystemNavigate _fileSystemNavigate;

    public MockParser(
        IMockCommandFactory mockCommandFactory,
        SystemNavigate fileSystemNavigate)
    {
        ValidatorService.ValidateObjectIfNull(mockCommandFactory);
        ValidatorService.ValidateObjectIfNull(fileSystemNavigate);

        _mockCommandFactory = mockCommandFactory;
        _fileSystemNavigate = fileSystemNavigate;
    }

    public Type? ParseCommand(Command command)
    {
        ValidatorService.ValidateObjectIfNull(command);

        string[] parts = command.Value.Split(' ');

        switch (parts[0])
        {
            case "connect":
                ICommand connectCommand = _mockCommandFactory.Create(new Text(parts[0]), parts);
                return connectCommand.GetType();
            case "disconnect":
                ICommand disconnectCommand = _mockCommandFactory.Create(new Text(parts[0]), parts);
                return disconnectCommand.GetType();
            case "file":
                ICommand fileCommand = _mockCommandFactory.Create(new Text(parts[1]), parts);
                return fileCommand.GetType();
            case "tree":
                ICommand treeCommand = _mockCommandFactory.Create(new Text(parts[1]), parts);
                return treeCommand.GetType();
            default:
                Console.WriteLine("Unknown command");
                break;
        }

        return null;
    }
}