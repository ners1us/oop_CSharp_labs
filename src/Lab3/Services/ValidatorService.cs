using System;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public static class ValidatorService
{
    public static void ValidateObjectIfNull(object? value)
    {
        if (value == null)
            ArgumentNullException.ThrowIfNull(value);
    }

    public static void ValidateAlreadyRead(IMessage message)
    {
        ValidateObjectIfNull(message);

        if (message.GetType() == typeof(ReadMessage))
            throw new AlreadyReadMessageException("The message is already read!");
    }
}