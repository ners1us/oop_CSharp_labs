using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class Timings
{
    public Timings(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Timings value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}