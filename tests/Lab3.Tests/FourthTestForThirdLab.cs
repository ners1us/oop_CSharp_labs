using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.UserRecipient;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Filter;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageDirector;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class FourthTestForThirdLab
{
    [Fact]
    public void NotAcceptingMessageBecauseOfItsImportanceLevelTest()
    {
        // Arrange
        var builder = new MessageBuilder();
        var director = new MessageDirector(builder);
        Message message = director.BuildCustomMessage(new Text("Some cool header"), new Text("Some cool body"), new Level(2));
        var topic = new Topic(new Text("Some topic name"));
        var user = new User(topic, new Level(1));
        var filter = new FilterMock(Substitute.For<Filter>());

        // Assert & Act
        Assert.Throws<NotEqualLevelImportanceException>(() => filter.FilterMessage(message, user.UserLevelImportance, user));
    }
}