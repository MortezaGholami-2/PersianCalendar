using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PersianCalendar.Wpf.ViewModels;

namespace PersianCalendar.Wpf.Contracts;

public interface INavigationViewService
{
    BaseViewModel CurrentViewModel { get; }
    ICommand UpdateCurrentViewModelCommand { get; }

    RadioButton? GetSelectedItem(Type pageType);
}
