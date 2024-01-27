using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

public interface IMessage
{
    public Text MessageHeader { get; }
    public Text MessageBody { get; }
    public Level MessageImportanceLevel { get; }
}