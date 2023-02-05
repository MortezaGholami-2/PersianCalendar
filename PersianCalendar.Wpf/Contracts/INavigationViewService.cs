using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using ModernWpf.Controls;
using PersianCalendar.Wpf.ViewModels;

namespace PersianCalendar.Wpf.Contracts;

public interface INavigationViewService
{
    void Initialize(NavigationView navigationView);

    void UnregisterEvents();
    
    NavigationViewItem? GetSelectedItem(Type pageType);
}
