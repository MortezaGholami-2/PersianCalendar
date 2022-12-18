using CommunityToolkit.Mvvm.ComponentModel;

namespace PersianCalendar.WinUI3.ViewModels;
public class CalendarViewModel : ObservableRecipient
{
    #region Properties
    
    private DateTime _CurrentDate;

    public DateTime CurrentDate
    {
        get => _CurrentDate;
        set => SetProperty(ref _CurrentDate, value);
    }

    #endregion
    public CalendarViewModel()
    {
        CurrentDate = DateTime.Now;
    }
}
