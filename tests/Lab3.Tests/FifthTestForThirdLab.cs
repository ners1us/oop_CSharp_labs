using Itmo.ObjectOrientedProgramming.Lab3.Models.Logger;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageDirector;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using NSubstitute;
using Xunit;
using Xunit.Abstractions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class FifthTestForThirdLab
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FifthTestForThirdLab(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void LogMessageWhenCalledLogsMessageToConsoleAndCountsCallsTest()
    {
        // Arrange
        ILogger? loggerMock = Substitute.For<ILogger>();
        var logger = new LoggerMock(loggerMock);
        int callCount = 0;
        var builder = new MessageBuilder();
        var director = new MessageDirector(builder);
        Message message = director.BuildCustomMessage(new Text("Some cool header"), new Text("Some cool body"), new Level(1));

        // Act
        loggerMock.LogMessage(Arg.Do<Text>(outputMessage =>
        {
            _testOutputHelper.WriteLine("Logged next message: " + outputMessage);
            callCount++;
        }));

        logger.LogMessage(message.MessageBody);

        // Assert
        loggerMock.Received(1).LogMessage(Arg.Any<Text>());
        Assert.Equal(1, callCount);
    }
}