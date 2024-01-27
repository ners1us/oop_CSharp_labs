namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.GroupRecipient;

public interface IGroup
{
    void AddRecipient(Recipient recipient);
    void RemoveRecipient(Recipient recipient);
}