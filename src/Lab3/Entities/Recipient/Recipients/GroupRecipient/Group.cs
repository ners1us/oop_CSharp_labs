using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.GroupRecipient;

public class Group : Recipient, IGroup
{
    private readonly List<Recipient> _recipients = new();

    public void AddRecipient(Recipient recipient)
    {
        ValidatorService.ValidateObjectIfNull(recipient);

        _recipients.Add(recipient);
    }

    public void RemoveRecipient(Recipient recipient)
    {
        ValidatorService.ValidateObjectIfNull(recipient);

        _recipients.Remove(recipient);
    }

    public override void GetMessageFromTopic(Message message)
    {
        foreach (Recipient recipient in _recipients)
        {
            recipient.GetMessageFromTopic(message);
        }
    }
}