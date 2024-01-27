using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Socket
{
    public Socket(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Socket value value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}