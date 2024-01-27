using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.UserRecipient;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageDirector;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class ThirdTestForThirdLab
{
    [Fact]
    public void ThrowExceptionBecauseOfTryingToReadReadMessageTest()
    {
        // Arrange
        var builder = new MessageBuilder();
        var director = new MessageDirector(builder);
        Message message = director.BuildCustomMessage(new Text("Greetings."), new Text("My name is Gustavo, but u can call me Gus"), new Level(1));
        var topic = new Topic(new Text("Some topic name"));
        var user = new User(topic, new Level(1));

        // Act
        user.GetMessageFromTopic(message);

        // Assert & Act
        Assert.Throws<AlreadyReadMessageException>(() => ValidatorService.ValidateAlreadyRead(user.MarkAsRead()));
    }
}