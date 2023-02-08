using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PersianCalendar.Wpf.ViewModels;

public class DashboardViewModel : ObservableRecipient
{
    public string PageTitle
    {
        get; set;
    }

    public DashboardViewModel()
    {
        PageTitle = "Dashboard Page";
    }
}
