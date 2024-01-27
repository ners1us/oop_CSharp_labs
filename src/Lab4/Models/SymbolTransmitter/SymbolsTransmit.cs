namespace Itmo.ObjectOrientedProgramming.Lab4.Models.SymbolTransmitter;

public class SymbolsTransmit
{
    public SymbolsTransmit(string? fileSign, string? folderSign, int indentSpaces)
    {
        FileSign = fileSign;
        FolderSign = folderSign;
        IndentSpaces = indentSpaces;
    }

    public string? FileSign { get; private set; }
    public string? FolderSign { get; private set; }
    public int IndentSpaces { get; private set; }
}