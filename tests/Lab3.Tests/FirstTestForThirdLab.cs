using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.UserRecipient;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageDirector;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class FirstTestForThirdLab
{
    [Fact]
    public void SaveMessageAsUnreadTest()
    {
        // Arrange
        var builder = new MessageBuilder();
        var director = new MessageDirector(builder);
        Message message = director.BuildCustomMessage(new Text("NEW IPHONE 16 IN 2023?!"), new Text("What the he-ee-el, o-oo-oh my go-oo-od, no way-yay-yay-yay-yea-aa-ah"), new Level(1));
        var topic = new Topic(new Text("Some topic name"));
        var user = new User(topic, new Level(1));

        // Act
        user.GetMessageFromTopic(message);

        // Assert & Act
        Assert.Same(typeof(UnreadMessage), user.KeepAsUnread().GetType());
    }
}