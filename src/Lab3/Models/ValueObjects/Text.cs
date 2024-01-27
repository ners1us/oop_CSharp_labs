using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.ValueObjects;

public class Text
{
    public Text(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Version value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}