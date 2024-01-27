using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.DisplayRecipient;

public class Display : Recipient
{
    private DisplayDriver _displayDriver;

    public Display(DisplayDriver displayDriver, Topic processedTopic, Level displayLevelImportance)
    {
        ValidatorService.ValidateObjectIfNull(processedTopic);
        ValidatorService.ValidateObjectIfNull(displayDriver);

        ProcessedTopic = processedTopic;
        DisplayLevelImportance = displayLevelImportance;
        _displayDriver = displayDriver;
    }

    public Level DisplayLevelImportance { get; private set; }
    public Topic ProcessedTopic { get; private set; }
    public Message? ReceivedDisplayMessage { get; private set; }

    public override void GetMessageFromTopic(Message message)
    {
        ValidatorService.ValidateObjectIfNull(message);

        ReceivedDisplayMessage = Topic.SendMessageToRecipient(message);
    }

    public void DisplayColoredMessage()
    {
        ValidatorService.ValidateObjectIfNull(ReceivedDisplayMessage?.MessageBody);

        _displayDriver.ClearDisplay();
        _displayDriver.SendColoredMessage(ReceivedDisplayMessage?.MessageBody);
    }
}