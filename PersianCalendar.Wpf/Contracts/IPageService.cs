using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianCalendar.Wpf.Contracts;
public interface IPageService
{
    Type GetPageType(string key);
}
