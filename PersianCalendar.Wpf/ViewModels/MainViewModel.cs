using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersianCalendar.Wpf.ViewModels;
public class MainViewModel : BaseViewModel
{
    public string PageTitle
    {
        get; set;
    }

    public MainViewModel()
    {
        PageTitle = "Main Page";
    }
}
