using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PersianCalendar.Core.Models;
using PersianCalendar.WinUI3.ViewModels;
using Windows.UI.Popups;

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

    private void AddShiftButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Shift shift = new() { Name = "mmmm" };
        try
        {
            //using (var context = new DatabaseContext())
            //{
            //    context.Shifts.Add(shift);
            //    context.SaveChanges();
            //    _ = new MessageDialog($"Added.");
            //}
        }
        catch (Exception ex)
        {
            _ = new MessageDialog($"exception: {ex}");
        }
    }

    private void QueryShiftsButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        List<Shift> shifts = new List<Shift>();
        shifts = QueryShifts().ToList();

        foreach (var item in shifts)
        {
            MyProperty3TextBlock.Text += item.Name;
        }
        //string a = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //using (var context = new PersianCalendarDatabaseContext(a))
        //{
        //    MyProperty3TextBlock.Text = context.DatabasePath;
        //}
    }

    private static IEnumerable<Shift> QueryShifts()
    {
        //SqliteDataService a=new SqliteDataService();
        //return a.GetShiftsAsync().Result;
        return default;
    }
}
