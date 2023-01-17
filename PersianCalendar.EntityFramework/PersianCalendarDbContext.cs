using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersianCalendar.WinUI3.Core.Models;

namespace PersianCalendar.EntityFramework;

public class PersianCalendarDbContext : DbContext
{
    DbSet<Shift> Shifts { get; set; }
    
    public PersianCalendarDbContext(DbContextOptions options) : base(options)
    {
    }
    
}
