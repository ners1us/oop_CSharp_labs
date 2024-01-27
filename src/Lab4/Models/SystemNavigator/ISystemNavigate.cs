using Itmo.ObjectOrientedProgramming.Lab4.Models.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Models.SystemNavigator;

public interface ISystemNavigate
{
    void GoToDirectory(Pathway path);
    void GoToParentDirectory();
}