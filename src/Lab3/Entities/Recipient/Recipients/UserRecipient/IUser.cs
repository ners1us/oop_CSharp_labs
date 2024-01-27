using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.UserRecipient;

public interface IUser
{
    ReadMessage MarkAsRead();
    UnreadMessage KeepAsUnread();
}