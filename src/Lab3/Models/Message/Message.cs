using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

public class Message : IMessage
{
    public Message(
        Text messageHeader,
        Text messageBody,
        Level messageImportanceLevel)
    {
        MessageHeader = messageHeader;
        MessageBody = messageBody;
        MessageImportanceLevel = messageImportanceLevel;
    }

    public Text MessageHeader { get; private set; }
    public Text MessageBody { get; private set; }
    public Level MessageImportanceLevel { get; private set; }
}