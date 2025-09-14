using Employees.Backend.Data;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.Responses;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Employees.Backend.Repositories.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DataContext _context;
    private readonly DbSet<T> _entity;

    public GenericRepository(DataContext context)
    {
        _context = context;
        _entity = context.Set<T>();
    }

    public virtual async Task<ActionResponse<T>> AddAsync(T entity)
    {
        _context.Add(entity);
        try
        {
            await _context.SaveChangesAsync();
            return new ActionResponse<T>
            {
                WasSuccess = true,
                Result = entity
            };
        }
        catch (Exception exception)
        {
            return ExceptionActionRespose(exception);
        }
    }

    public virtual async Task<ActionResponse<T>> DeleteAsync(int id)
    {
        var row = await _entity.FindAsync(id);
        if (row == null)
        {
            return new ActionResponse<T>
            {
                Message = "Registro no encontrado"
            };
        }
        _entity.Remove(row);

        try
        {
            await _context.SaveChangesAsync();
            return new ActionResponse<T>
            {
                WasSuccess = true
            };
        }
        catch
        {
            return new ActionResponse<T>
            {
                Message = "No se puede borrar porque tiene registros relacionados."
            };
        }
    }

    public virtual async Task<ActionResponse<T>> GetAsync(int id)
    {
        var row = await _entity.FindAsync(id);
        if (row == null)
        {
            return new ActionResponse<T>
            {
                Message = "Registro no encontrado"
            };
        }
        return new ActionResponse<T>
        {
            WasSuccess = true,
            Result = row
        };
    }

    public virtual async Task<ActionResponse<IEnumerable<T>>> GetAsync() => new ActionResponse<IEnumerable<T>>
    {
        WasSuccess = true,
        Result = await _entity.ToListAsync()
    };

    public virtual async Task<ActionResponse<T>> UpdateAsync(T entity)
    {
        _context.Update(entity);
        try
        {
            await _context.SaveChangesAsync();
            return new ActionResponse<T>
            {
                WasSuccess = true,
                Result = entity
            };
        }
        catch (Exception exception)
        {
            return ExceptionActionRespose(exception);
        }
    }

    public async Task<ActionResponse<IEnumerable<T>>> GetAsync(Expression<Func<T, bool>> predicate)
    {
        try
        {
            var results = await _context.Set<T>().Where(predicate).ToListAsync();
            return new ActionResponse<IEnumerable<T>>
            {
                WasSuccess = true,
                Result = results
            };
        }
        catch (Exception ex)
        {
            return new ActionResponse<IEnumerable<T>>
            {
                WasSuccess = false,
                Message = ex.Message
            };
        }
    }

    private ActionResponse<T> ExceptionActionRespose(Exception exception) => new ActionResponse<T>
    {
        Message = exception.Message
    };
}