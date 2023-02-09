using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PersianCalendar.WinUI3.ViewModels;
public partial class CalendarViewModel : ObservableRecipient
{
    #region Properties

    [ObservableProperty]
    private ushort? selectedPersianYear;

    [ObservableProperty]
    private ushort? selectedPersianMonth;

    [ObservableProperty]
    private ushort? selectedPersianDay;

    private DateTime _CurrentDate;
    private int _CurrentPersianYear;
    private int _CurrentPersianMonth;

    public DateTime CurrentDate
    {
        get => _CurrentDate;
        set => SetProperty(ref _CurrentDate, value);
    }
    public int CurrentPersianYear
    {
        get => _CurrentPersianYear;
        set => SetProperty(ref _CurrentPersianYear, value);
    }
    public int CurrentPersianMonth
    {
        get => _CurrentPersianMonth;
        set => SetProperty(ref _CurrentPersianMonth, value);
    }




    private ObservableCollection<int?> _Days;
    public ObservableCollection<int?> Days
    {
        get => _Days;
        set => SetProperty(ref _Days, value);
    }





    private int _DaysOfMonth;
    public int DaysOfMonth
    {
        get => _DaysOfMonth;
        set => SetProperty(ref _DaysOfMonth, value);
    }

    private int _NumberOfRowsOfCalendar;
    public int NumberOfRowsOfCalendar
    {
        get => _NumberOfRowsOfCalendar;
        set => SetProperty(ref _NumberOfRowsOfCalendar, value);
    }

    private PersianDayOfWeek myVar;
    public PersianDayOfWeek MyProperty
    {
        get => myVar;
        set => SetProperty(ref myVar, value);
    }

    private bool _SixthRowVisibility;
    public bool SixthRowVisibility
    {
        get => _SixthRowVisibility;
        set => SetProperty(ref _SixthRowVisibility, value);
    }

    private int myVar2;
    public int MyProperty2
    {
        get => myVar2;
        set => SetProperty(ref myVar2, value);
    }



    #endregion
    public CalendarViewModel()
    {
        SelectedPersianYear = 1399;
        SelectedPersianMonth = 12;

        CurrentDate = DateTime.Now;
        CurrentPersianYear = 1402;
        CurrentPersianMonth = 2;

        System.Globalization.PersianCalendar persianCalendar = new();
        DateTime tempDate = new DateTime(CurrentPersianYear, CurrentPersianMonth, 1, persianCalendar);
        DaysOfMonth = persianCalendar.GetDaysInMonth(CurrentPersianYear, CurrentPersianMonth);
        string a = persianCalendar.GetDayOfWeek(tempDate).ToString();
        MyProperty = (PersianDayOfWeek)Enum.Parse(typeof(PersianDayOfWeek), a);
        MyProperty2 = (int)Enum.Parse(typeof(PersianDayOfWeek),MyProperty.ToString());
        if (persianCalendar.GetDaysInMonth(CurrentPersianYear, CurrentPersianMonth) + MyProperty2 + 1 <= 35)
        {
            NumberOfRowsOfCalendar = 5;
            SixthRowVisibility = false;
        }
        else
        {
            NumberOfRowsOfCalendar = 6;
            SixthRowVisibility = true;
        }

        Days = new ObservableCollection<int?>();
        for (var i = 0; i < 42; i++)
        {
            Days.Add(null);
        }
        for (var i = MyProperty2; i < DaysOfMonth + MyProperty2; i++)
        {
            Days[i] = i - MyProperty2 + 1;
        }

    }

    public enum PersianDayOfWeek
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
}
