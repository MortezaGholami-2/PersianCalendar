using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernWpf.Controls;
using System.Windows;

namespace PersianCalendar.Wpf.Helpers;
public class NavigationViewHelper
{
    // Helper class to set the navigation target for a NavigationViewItem.
    //
    // Usage in XAML:
    // <NavigationViewItem x:Uid="Shell_Main" Icon="Document" helpers:NavigationHelper.NavigateTo="AppName.ViewModels.MainViewModel" />
    //
    // Usage in code:
    // NavigationHelper.SetNavigateTo(navigationViewItem, typeof(MainViewModel).FullName);

    public static string GetNavigateTo(NavigationViewItem item) => (string)item.GetValue(NavigateToDependencyProperty);

    public static void SetNavigateTo(NavigationViewItem item, string value) => item.SetValue(NavigateToDependencyProperty, value);

    public static readonly DependencyProperty NavigateToDependencyProperty =
        DependencyProperty.RegisterAttached("NavigateTo", typeof(string), typeof(NavigationViewHelper), new PropertyMetadata(null));
}
