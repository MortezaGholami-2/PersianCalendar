using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace PersianCalendar.EntityFramework;
public class PersianCalendarDbContextFactory : IDesignTimeDbContextFactory<PersianCalendarDbContext>
{
    public PersianCalendarDbContext CreateDbContext(string[] args = null)
    {
        var options = new DbContextOptionsBuilder<PersianCalendarDbContext>();
        options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PersianCalendarDb;Trusted_Connection=true");
        return new PersianCalendarDbContext(options.Options);
    }
}
