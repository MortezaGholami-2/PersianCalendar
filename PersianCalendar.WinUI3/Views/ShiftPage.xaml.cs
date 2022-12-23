using Microsoft.UI.Xaml.Controls;

using PersianCalendar.WinUI3.ViewModels;

namespace PersianCalendar.WinUI3.Views;

public sealed partial class ShiftPage : Page
{
    public ShiftViewModel ViewModel
    {
        get;
    }

    public ShiftPage()
    {
        ViewModel = App.GetService<ShiftViewModel>();
        InitializeComponent();
    }
}
