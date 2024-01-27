using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Filter;

public interface IFilter
{
    void FilterByLevelImportance(Message.Message message, Level importance, Recipient recipient);
}