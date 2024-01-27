using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message.MessageBuilder;

public interface IMessageBuilder
{
    void AddLevelImportance(Level level);
    void AddHeader(Text header);
    void AddBody(Text body);
    Message BuildMessage();
}