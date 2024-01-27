using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.DisplayRecipient;

public interface IDisplayDriver
{
    void SendColoredMessage(Text? value);
    void ClearDisplay();
    public void WriteText(Text value);
}