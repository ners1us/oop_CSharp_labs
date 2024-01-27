using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

public static class ValidatorService
{
    public static void ValidateObjectIfNull(object? value)
    {
        if (value == null)
            ArgumentNullException.ThrowIfNull(value);
    }
}