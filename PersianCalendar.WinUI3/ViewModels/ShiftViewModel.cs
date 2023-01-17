using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PersianCalendar.WinUI3.Core.Models;

namespace PersianCalendar.WinUI3.ViewModels;
public class ShiftViewModel : ObservableRecipient
{
    #region Properties

    //private ObservableCollection<ShiftDay> _Shift;

    /*
     * shiftday: dayTitle, person
     * 
     */










    private DateTime _CurrentDate;
    private int _ReferencePersianYear;
    private int _ReferencePersianMonth;
    private int _ReferencePersianDay;
    private int _DateDifference;
    private int _CurrentPersianYear;
    private int _CurrentPersianMonth;

    public DateTime CurrentDate
    {
        get => _CurrentDate;
        set => SetProperty(ref _CurrentDate, value);
    }
    public int ReferencePersianYear
    {
        get => _ReferencePersianYear;
        set => SetProperty(ref _ReferencePersianYear, value);
    }
    public int ReferencePersianMonth
    {
        get => _ReferencePersianMonth;
        set => SetProperty(ref _ReferencePersianMonth, value);
    }
    public int ReferencePersianDay
    {
        get => _ReferencePersianDay;
        set => SetProperty(ref _ReferencePersianDay, value);
    }

    public int DateDifference
    {
        get => _DateDifference;
        set => SetProperty(ref _DateDifference, value);
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

    private string _MyProperty3;

    public string MyProperty3
    {
        get => _MyProperty3;
        set => SetProperty(ref _MyProperty3, value);
    }




    #endregion

    

    public ShiftViewModel()
    {
        

        ReferencePersianYear = 1401;
        ReferencePersianMonth = 9;
        ReferencePersianDay = 21;


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

        
        DateDifference = (int)(persianCalendar.ToDateTime(1401, 10, 20, 0, 0, 0, 0) - persianCalendar.ToDateTime(1401, 9, 5, 0, 0, 0, 0)).TotalDays;
        MyProperty2=DateDifference%8;



        //var db = new BloggingContext();
        //MyProperty3 = _databaseContext.Shifts.Count().ToString();



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
