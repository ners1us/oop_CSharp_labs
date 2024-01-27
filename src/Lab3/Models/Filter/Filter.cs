using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Filter;

public class Filter : IFilter
{
    public void FilterByLevelImportance(Message.Message message, Level importance, Recipient recipient)
    {
        ValidatorService.ValidateObjectIfNull(message);
        ValidatorService.ValidateObjectIfNull(recipient);

        if (message.MessageImportanceLevel != importance)
            throw new NotEqualLevelImportanceException("Levels are different");

        recipient.GetMessageFromTopic(message);
    }
}