using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianCalendar.Wpf.ViewModels.Design;

public class ShellViewModelDesign
{
    public string PageTitle
    {
        get; set;
    }

    /// <summary>
    /// Gets the collection of available subreddits to pick from.
    /// </summary>
    public IReadOnlyList<string> NavigationViewItems
    {
        get;
    } = new[]
    {
        "microsoft",
        "windows",
        "surface",
        "windowsphone",
        "dotnet",
        "csharp"
    };

    public ShellViewModelDesign()
    {
        PageTitle = "Main Page_Design";
    }
}
