namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

public class ReadMessage : MessageDecorator
{
    public ReadMessage(IMessage wrapper)
        : base(wrapper)
    {
    }
}