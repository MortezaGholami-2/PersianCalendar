using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PersianCalendar.WinUI3.Core.Models;
using PersianCalendar.WinUI3.Core.Services;

namespace PersianCalendar.EntityFramework.Services;
public class GenericDataService<T> : IDataService<T> where T : BaseModel
{
    private readonly PersianCalendarDbContextFactory _contextFactory;

    public GenericDataService(PersianCalendarDbContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<T> Create(T entity)
    {
        using PersianCalendarDbContext context = _contextFactory.CreateDbContext();
        EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();

        return createdResult.Entity;
    }

    public async Task<bool> Delete(int id)
    {
        using PersianCalendarDbContext context = _contextFactory.CreateDbContext();
        T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
        context.Set<T>().Remove(entity);
        await context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        using PersianCalendarDbContext context = _contextFactory.CreateDbContext();
        IEnumerable<T> entities = await context.Set<T>().ToListAsync();

        return entities;
    }
    
    public async Task<T> GetById(int id)
    {
        using PersianCalendarDbContext context = _contextFactory.CreateDbContext();
        T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
        
        return entity;
    }
    
    public async Task<T> GetByName(string name) => throw new NotImplementedException();
    
    public async Task<T> Update(int id, T entity)
    {
        using PersianCalendarDbContext context = _contextFactory.CreateDbContext();
        entity.Id = id;
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();

        return entity;
    }
}
