using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersianCalendar.WinUI3.Database.Models;

namespace PersianCalendar.WinUI3.Database.Services;
public interface IDataService
{
    Task<IEnumerable<Shift>?> GetShiftsAsync();
}
