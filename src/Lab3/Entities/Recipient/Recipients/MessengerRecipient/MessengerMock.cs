namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.MessengerRecipient;

public class MessengerMock
{
    private readonly IMessenger _messenger;

    public MessengerMock(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void OutputMessage() => _messenger.MessengerOutput();
}