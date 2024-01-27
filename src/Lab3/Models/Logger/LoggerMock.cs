using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Logger;

public class LoggerMock
{
    private readonly ILogger _logger;

    public LoggerMock(ILogger logger)
    {
        _logger = logger;
    }

    public void LogMessage(Text message) => _logger.LogMessage(message);
}