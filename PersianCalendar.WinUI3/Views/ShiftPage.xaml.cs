using Microsoft.UI.Xaml.Controls;
using PersianCalendar.WinUI3.Core.Database;
using PersianCalendar.WinUI3.Database.Models;
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
            using (var context = new PersianCalendarDatabaseContext())
            {
                context.Shifts.Add(shift);
                context.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            _ = new MessageDialog($"exception: {ex}");
        }
    }

    private void QueryShiftsButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        //List<Shift> shifts = new List<Shift>();
        //shifts = QueryShifts();

        //foreach (var item in shifts)
        //{
        //    MyProperty3TextBlock.Text += item.Name;
        //}
        using (var context = new PersianCalendarDatabaseContext())
        {
            MyProperty3TextBlock.Text=context.
        }
    }

    private static List<Shift> QueryShifts()
    {
        try
        {
            using (var context = new PersianCalendarDatabaseContext())
            {
                var shifts = context.Shifts.ToList();
                if (shifts != null)
                {
                    return shifts;
                }
                return default;
            }
        }
        catch (Exception ex)
        {
            _ = new MessageDialog($"exception: {ex}");
            return default;
        }
    }
}
