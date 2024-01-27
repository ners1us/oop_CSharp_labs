using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient;

public abstract class Recipient
{
    public static Message SendMessage(Message message)
    {
        ValidatorService.ValidateObjectIfNull(message);

        return message;
    }

    public abstract void GetMessageFromTopic(Message message);
}