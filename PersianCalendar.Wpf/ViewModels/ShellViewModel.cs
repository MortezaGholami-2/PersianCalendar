using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using ModernWpf.Navigation;
using PersianCalendar.Wpf.Contracts;
using PersianCalendar.Wpf.Services;

namespace PersianCalendar.Wpf.ViewModels;
public class ShellViewModel : ObservableRecipient
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
    
    private bool _isBackEnabled;
    private object? _selected;

    public INavigationService NavigationService
    {
        get;
    }

    public INavigationViewService NavigationViewService
    {
        get;
    }

    public bool IsBackEnabled
    {
        get => _isBackEnabled;
        set => SetProperty(ref _isBackEnabled, value);
    }

    public object? Selected
    {
        get => _selected;
        set => SetProperty(ref _selected, value);
    }

    public ShellViewModel(INavigationService navigationService, INavigationViewService navigationViewService)
    {
        NavigationService = navigationService;
        NavigationService.Navigated += OnNavigated;
        NavigationViewService = navigationViewService;
        
        PageTitle = "Main Page";
    }

    private void OnNavigated(object sender, NavigationEventArgs e)
    {
        IsBackEnabled = NavigationService.CanGoBack;

        //if (e.SourcePageType == typeof(SettingsPage))
        //{
        //    Selected = NavigationViewService.SettingsItem;
        //    return;
        //}

        var selectedItem = NavigationViewService.GetSelectedItem(e.SourcePageType());
        if (selectedItem != null)
        {
            Selected = selectedItem;
        }
    }
}
