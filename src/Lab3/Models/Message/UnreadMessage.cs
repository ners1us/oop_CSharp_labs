namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

public class UnreadMessage : MessageDecorator
{
    public UnreadMessage(IMessage wrapper)
        : base(wrapper)
    {
    }
}