using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;

public class MessageBuilder : IMessageBuilder
{
    private Level? _level;
    private Text? _body;
    private Text? _header;

    public void AddLevelImportance(Level level)
    {
        _level = level;
    }

    public void AddHeader(Text header)
    {
        _header = header;
    }

    public void AddBody(Text body)
    {
        _body = body;
    }

    public Message BuildMessage()
    {
        if (_body == null || _level == null || _header == null)
            throw new ArgumentNullException();

        return new Message(_header, _body, _level);
    }
}