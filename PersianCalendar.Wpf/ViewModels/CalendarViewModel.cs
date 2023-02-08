using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PersianCalendar.Wpf.ViewModels;

public class CalendarViewModel : ObservableRecipient
{
    public string PageTitle
    {
        get; set;
    }

    public CalendarViewModel()
    {
        PageTitle = "Calendar Page";
    }
}
