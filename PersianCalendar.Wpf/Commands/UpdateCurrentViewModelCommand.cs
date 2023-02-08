using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PersianCalendar.Wpf.Contracts;
using PersianCalendar.Wpf.ViewModels;

namespace PersianCalendar.Wpf.Commands;
public class UpdateCurrentViewModelCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;
    private INavigationViewService _INavigationViewService;
    public UpdateCurrentViewModelCommand(INavigationViewService iNavigationViewService)
    {
        _INavigationViewService = iNavigationViewService;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }
    public void Execute(object? parameter)
    {
        //if (parameter is ViewType)
        //{
        //    ViewType viewType = (ViewType)parameter;
        //    switch (viewType)
        //    {
        //        case ViewType.Dashboard:
        //            _INavigationViewService.CurrentViewModel = new DashboardViewModel();
        //            break;
        //        case ViewType.Calendar:
        //            _INavigationViewService.CurrentViewModel = new CalendarViewModel();
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}