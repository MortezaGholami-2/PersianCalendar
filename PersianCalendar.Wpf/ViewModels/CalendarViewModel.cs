using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianCalendar.Wpf.ViewModels
{
    public class CalendarViewModel : BaseViewModel
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
}
