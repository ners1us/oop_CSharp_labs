using System;
using Itmo.ObjectOrientedProgramming.Lab4.Models.CommandParser;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.ConsoleApp;

public static class ConsoleApp
{
    public static void RunApp()
    {
        var parser = new Parser();
        const string folderSymbol = "+";
        const string fileSymbol = "-";
        const int indentSpaces = 2;

        parser.ReceiveTreeListCommandSymbols(folderSymbol, fileSymbol, indentSpaces);

        while (true)
        {
            Console.Write("ubuntu@user:-$ ");
            string? command = Console.ReadLine();

            ArgumentNullException.ThrowIfNull(command);

            parser.ParseCommand(new Command(command));
        }
    }
}