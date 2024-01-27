using Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageDirector;

public class MessageDirector
{
    private readonly IMessageBuilder _messageBuilder;

    public MessageDirector(IMessageBuilder messageBuilder)
    {
        _messageBuilder = messageBuilder;
    }

    public Message BuildCustomMessage(Text header, Text body, Level level)
    {
        _messageBuilder.AddHeader(header);
        _messageBuilder.AddBody(body);
        _messageBuilder.AddLevelImportance(level);
        return _messageBuilder.BuildMessage();
    }
}