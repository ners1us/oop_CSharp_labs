using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.UserRecipient;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageDirector;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class SecondTestForThirdLab
{
    [Fact]
    public void ChangeMessageStatusWhileItIsUnreadTest()
    {
        // Arrange
        var builder = new MessageBuilder();
        var director = new MessageDirector(builder);
        Message message = director.BuildCustomMessage(new Text("I can't believe it!"), new Text("I've just gotten 1000000$ from Mr. Beast!"), new Level(1));
        var topic = new Topic(new Text("Some topic name"));
        var user = new User(topic, new Level(1));

        // Act
        user.GetMessageFromTopic(message);

        // Assert & Act
        Assert.Same(typeof(ReadMessage), user.MarkAsRead().GetType());
    }
}