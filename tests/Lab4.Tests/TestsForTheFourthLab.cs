using Itmo.ObjectOrientedProgramming.Lab4.Entities.CommandFactory;
using Itmo.ObjectOrientedProgramming.Lab4.Models.CommandParser;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.Commands.SystemCommands;
using Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;
using Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class TestsForTheFourthLab
{
    [Fact]
    public void ShowCommandParsingTest()
    {
        // Arrange
        var path = new Pathway("/path/to/filesystem");
        var commandText = new Command($"file show {path} -m console");
        var systemNavigator = new SystemNavigate(path);
        var fileViewer = new FileView();
        var commandFactory = new MockCommandFactory(fileViewer, systemNavigator);
        var commandParser = new MockParser(commandFactory, new SystemNavigate(path));

        // Act & Assert
        Assert.Same(typeof(FileShowCommand), commandParser.ParseCommand(commandText));
    }

    [Fact]
    public void DisconnectCommandParsingTest()
    {
        // Arrange
        var path = new Pathway("/another_path/to/filesystem");
        var commandText = new Command("disconnect");
        var systemNavigator = new SystemNavigate(path);
        var fileViewer = new FileView();
        var commandFactory = new MockCommandFactory(fileViewer, systemNavigator);
        var commandParser = new MockParser(commandFactory, systemNavigator);

        // Act & Assert
        Assert.Same(typeof(SystemDisconnectCommand), commandParser.ParseCommand(commandText));
    }

    [Fact]
    public void MoveCommandParsingTest()
    {
        // Arrange
        var path = new Pathway("/another_path/to/filesystem");
        var currentPath = new Pathway(path + "/some_folder");
        var newPath = new Pathway(path + "/another_folder");
        var commandText = new Command($"file move {currentPath} {newPath}");
        var systemNavigator = new SystemNavigate(path);
        var fileViewer = new FileView();
        var commandFactory = new MockCommandFactory(fileViewer, systemNavigator);
        var commandParser = new MockParser(commandFactory, systemNavigator);

        // Act & Assert
        Assert.Same(typeof(FileMoveCommand), commandParser.ParseCommand(commandText));
    }

    [Fact]
    public void DeleteCommandParsingTest()
    {
        // Arrange
        var path = new Pathway("/another_path/to/filesystem");
        var commandText = new Command($"file delete {path}");
        var systemNavigator = new SystemNavigate(path);
        var fileViewer = new FileView();
        var commandFactory = new MockCommandFactory(fileViewer, systemNavigator);
        var commandParser = new MockParser(commandFactory, systemNavigator);

        // Act & Assert
        Assert.Same(typeof(FileDeleteCommand), commandParser.ParseCommand(commandText));
    }

    [Fact]
    public void RenameCommandParsingTest()
    {
        // Arrange
        var path = new Pathway("/another_path/to/filesystem");
        var newName = new Pathway(path.Value + "/some_new_name");
        var commandText = new Command($"file rename {path} {newName}");
        var systemNavigator = new SystemNavigate(path);
        var fileViewer = new FileView();
        var commandFactory = new MockCommandFactory(fileViewer, systemNavigator);
        var commandParser = new MockParser(commandFactory, systemNavigator);

        // Act & Assert
        Assert.Same(typeof(FileRenameCommand), commandParser.ParseCommand(commandText));
    }
}