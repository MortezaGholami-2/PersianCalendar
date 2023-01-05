using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersianCalendar.WinUI3.Database.Models;
using Windows.UI.Popups;

namespace PersianCalendar.WinUI3.Database.Services;
public class SqliteDataService : IDataService
{
    public async Task<IEnumerable<Shift>?> GetShiftsAsync()
    {
        try
        {
            using var context = new DatabaseContext();
            var shifts = context.Shifts.ToList();
            await Task.CompletedTask;
            if (shifts != null)
            {
                return shifts;
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            _ = new MessageDialog($"exception: {ex}");
            return null;
        }
    }
}
