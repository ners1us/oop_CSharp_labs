using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Topic;

public class Topic
{
    public Topic(Text topicName)
    {
        TopicName = topicName;
    }

    public Text TopicName { get; private set; }
    public static Message.Message SendMessageToRecipient(Message.Message message) => Recipient.SendMessage(message);
}