using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.MessengerRecipient;

public class Messenger : Recipient, IMessenger
{
    public Messenger(Topic processedTopic, Level messengerLevelImportance)
    {
        ValidatorService.ValidateObjectIfNull(processedTopic);

        ProcessedTopic = processedTopic;
        MessengerLevelImportance = messengerLevelImportance;
    }

    public Level MessengerLevelImportance { get; private set; }
    public Topic ProcessedTopic { get; private set; }
    public Message? ReceivedMessengerMessage { get; private set; }

    public override void GetMessageFromTopic(Message message)
    {
        ValidatorService.ValidateObjectIfNull(message);

        ReceivedMessengerMessage = Topic.SendMessageToRecipient(message);
    }

    public void MessengerOutput()
    {
        Console.WriteLine("Messenger output: " + ReceivedMessengerMessage);
    }
}