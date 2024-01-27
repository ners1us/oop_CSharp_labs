using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.MessengerRecipient;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class SixthTestForThirdLab
{
    [Fact]
    public void MessengerOutputCallsConsoleWriteLineTest()
    {
        // Arrange
        IMessenger? messenger = Substitute.For<IMessenger>();
        var messengerMock = new MessengerMock(messenger);

        // Act
        messengerMock.OutputMessage();

        // Assert
        messenger.Received(1).MessengerOutput();
    }
}