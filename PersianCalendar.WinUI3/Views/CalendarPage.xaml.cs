using Microsoft.UI.Xaml.Controls;

using PersianCalendar.WinUI3.ViewModels;

namespace PersianCalendar.WinUI3.Views;

public sealed partial class CalendarPage : Page
{
    public CalendarViewModel ViewModel
    {
        get;
    }

    public CalendarPage()
    {
        ViewModel = App.GetService<CalendarViewModel>();
        InitializeComponent();
    }
}
