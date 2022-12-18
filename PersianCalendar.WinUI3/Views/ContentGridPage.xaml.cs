using Microsoft.UI.Xaml.Controls;

using PersianCalendar.WinUI3.ViewModels;

namespace PersianCalendar.WinUI3.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
