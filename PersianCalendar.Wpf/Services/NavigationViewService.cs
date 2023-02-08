using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using ModernWpf.Controls;
using PersianCalendar.Wpf.Commands;
using PersianCalendar.Wpf.Contracts;
using PersianCalendar.Wpf.Controls;
using PersianCalendar.Wpf.Helpers;
using PersianCalendar.Wpf.ViewModels;

namespace PersianCalendar.Wpf.Services;
public class NavigationViewService : INavigationViewService
{
    private readonly INavigationService _navigationService;
    private readonly IPageService _pageService;
    private NavigationView? _navigationView;
    //public IList<object>? MenuItems => _navigationView?.MenuItems;
    public IList<object>? MenuItems => (IList<object>?)(_navigationView?.MenuItems);

    public object? SettingsItem => _navigationView?.SettingsItem;

    public NavigationViewService(INavigationService navigationService, IPageService pageService)
    {
        _navigationService = navigationService;
        _pageService = pageService;
    }

    public void Initialize(NavigationView navigationView)
    {
        _navigationView = navigationView;
        _navigationView.BackRequested += OnBackRequested;
        _navigationView.ItemInvoked += OnItemInvoked;
    }

    public void UnregisterEvents()
    {
        if (_navigationView != null)
        {
            _navigationView.BackRequested -= OnBackRequested;
            _navigationView.ItemInvoked -= OnItemInvoked;
        }
    }

    private void OnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args) => _navigationService.GoBack();

    private void OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        if (args.IsSettingsInvoked)
        //{
        //    _navigationService.NavigateTo(typeof(SettingsViewModel).FullName!);
        //}
        //else
        {
            var selectedItem = args.InvokedItemContainer as NavigationViewItem;

            if (selectedItem?.GetValue(NavigationViewHelper.NavigateToDependencyProperty) is string pageKey)
            {
                _navigationService.NavigateTo(pageKey);
            }
        }
    }

    public NavigationViewItem? GetSelectedItem(Type pageType)
    {
        if (_navigationView != null)
        {
            return GetSelectedItem((IEnumerable<object>)_navigationView.MenuItems, pageType) ?? GetSelectedItem((IEnumerable<object>)_navigationView.FooterMenuItems, pageType);
        }

        return null;
    }

    private NavigationViewItem? GetSelectedItem(IEnumerable<object> menuItems, Type pageType)
    {
        foreach (var item in menuItems.OfType<NavigationViewItem>())
        {
            if (IsMenuItemForPageType(item, pageType))
            {
                return item;
            }

            var selectedChild = GetSelectedItem((IEnumerable<object>)item.MenuItems, pageType);
            if (selectedChild != null)
            {
                return selectedChild;
            }
        }

        return null;
    }

    private bool IsMenuItemForPageType(NavigationViewItem navigationViewItem, Type sourcePageType)
    {
        if (navigationViewItem.GetValue(NavigationViewHelper.NavigateToDependencyProperty) is string pageKey)
        {
            return _pageService.GetPageType(pageKey) == sourcePageType;
        }

        return false;
    }
}
