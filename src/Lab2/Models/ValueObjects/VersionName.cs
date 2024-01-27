using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ValueObjects;

public class VersionName
{
    public VersionName(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Version value shouldn't be null!");

        Value = value;
    }

    public string Value { get; }
}