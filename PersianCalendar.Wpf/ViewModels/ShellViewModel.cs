using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersianCalendar.Wpf.ViewModels;
public class ShellViewModel : BaseViewModel
{
    public string PageTitle
    {
        get; set;
    }

    /// <summary>
    /// Gets the collection of available subreddits to pick from.
    /// </summary>
    public IReadOnlyList<string> NavigationViewItems { get; } = new[]
    {
        "microsoft",
        "windows",
        "surface",
        "windowsphone"
    };

    public ShellViewModel()
    {
        PageTitle = "Main Page";
    }
}
