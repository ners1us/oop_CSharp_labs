using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Logger;

public class Logger : ILogger
{
    public void LogMessage(Text message) => Console.WriteLine("Logged next message: " + message);
}