using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Services.ValidatorService;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;

public class SystemNavigate : ISystemNavigate
{
    public SystemNavigate(Pathway currentPath)
    {
        ValidatorService.ValidateObjectIfNull(currentPath);

        CurrentPath = currentPath;
    }

    public Pathway CurrentPath { get; private set; }

    public void GoToDirectory(Pathway path)
    {
        ValidatorService.ValidateObjectIfNull(path);

        CurrentPath = new Pathway(Path.Combine(CurrentPath.Value, path.Value));
    }

    public void GoToParentDirectory()
    {
        string? gotDirectoryParent = Directory.GetParent(CurrentPath.Value)?.FullName;

        ArgumentNullException.ThrowIfNull(gotDirectoryParent);

        var path = new Pathway(gotDirectoryParent);
        CurrentPath = path;
    }
}