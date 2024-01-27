using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.UserRecipient;

public class User : Recipient, IUser
{
    public User(Topic processedTopic, Level userLevelImportance)
    {
        ValidatorService.ValidateObjectIfNull(processedTopic);

        ProcessedTopic = processedTopic;
        UserLevelImportance = userLevelImportance;
    }

    public Level UserLevelImportance { get; private set; }
    public Topic ProcessedTopic { get; private set; }
    public Message? ReceivedUserMessage { get; private set; }

    public override void GetMessageFromTopic(Message message)
    {
        ValidatorService.ValidateObjectIfNull(message);

        ReceivedUserMessage = Topic.SendMessageToRecipient(message);
    }

    public ReadMessage MarkAsRead()
    {
        if (ReceivedUserMessage == null)
            throw new ArgumentNullException();

        ValidatorService.ValidateAlreadyRead(ReceivedUserMessage);

        return new ReadMessage(ReceivedUserMessage);
    }

    public UnreadMessage KeepAsUnread()
    {
        if (ReceivedUserMessage == null)
            throw new ArgumentNullException();

        return new UnreadMessage(ReceivedUserMessage);
    }
}