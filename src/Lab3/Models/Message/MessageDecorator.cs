using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

public abstract class MessageDecorator : IMessage
{
    protected MessageDecorator(IMessage wrapper)
    {
        ValidatorService.ValidateObjectIfNull(wrapper);

        Wrapper = wrapper;
        MessageHeader = wrapper.MessageHeader;
        MessageBody = wrapper.MessageBody;
        MessageImportanceLevel = wrapper.MessageImportanceLevel;
    }

    public IMessage Wrapper { get; }
    public Text MessageHeader { get; }
    public Text MessageBody { get; }
    public Level MessageImportanceLevel { get; }
}