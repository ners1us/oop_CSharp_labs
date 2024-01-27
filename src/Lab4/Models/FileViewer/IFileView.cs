using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;

public interface IFileView
{
    void ShowFile(Pathway path);
}