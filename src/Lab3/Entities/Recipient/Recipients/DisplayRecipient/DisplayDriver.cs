using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Recipient.Recipients.DisplayRecipient;

public class DisplayDriver : IDisplayDriver
{
    private readonly ConsoleColor _textColor;
    private Text? _savedText;

    public DisplayDriver(ConsoleColor textColor)
    {
        _textColor = textColor;
    }

    public void ClearDisplay()
    {
        Console.Clear();
    }

    public void SendColoredMessage(Text? value)
    {
        ValidatorService.ValidateObjectIfNull(value);

        Console.ForegroundColor = _textColor;
        Console.WriteLine(value);
    }

    public void WriteText(Text value)
    {
        _savedText = value;
    }
}