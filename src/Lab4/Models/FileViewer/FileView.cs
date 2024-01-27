using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.FileViewer;

public class FileView : IFileView
{
    public void ShowFile(Pathway path)
    {
        ValidatorService.ValidateObjectIfNull(path);

        Console.WriteLine(new Text(File.ReadAllText(path.Value)));
    }
}