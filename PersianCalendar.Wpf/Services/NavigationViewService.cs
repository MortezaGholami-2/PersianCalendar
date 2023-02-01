using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersianCalendar.Wpf.Controls;

namespace PersianCalendar.Wpf.Services;
public class NavigationViewService
{
    private NavigationView navigationView;

    public NavigationViewService()
    {
        navigationView = new NavigationView();
    }
    public object? GetSelectedItem(Type pageType)
    {
        if (navigationView != null)
        {
            return GetSelectedItem(navigationView.MenuItems, pageType) ?? GetSelectedItem(navigationView.FooterMenuItems, pageType);
        }

        return null;
    }
}
