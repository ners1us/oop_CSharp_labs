using Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Filter;

public class FilterMock
{
    private readonly IFilter _filter;

    public FilterMock(IFilter filter)
    {
        _filter = filter;
    }

    public void FilterMessage(Message.Message message, Level importance, Recipient recipient)
    {
        _filter.FilterByLevelImportance(message, importance, recipient);
    }
}