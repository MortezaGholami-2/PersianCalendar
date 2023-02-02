using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersianCalendar.Wpf.Contracts;

public interface INavigationViewService
{
    RadioButton? GetSelectedItem(Type pageType);
}
