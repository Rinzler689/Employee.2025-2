using Employees.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employees.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckEmployeesFullAsync();
    }

    private async Task CheckEmployeesFullAsync()
    {
        if (!_context.Employees.Any())
        {
            var employeesSQLScript = File.ReadAllText("Data\\EmployeesTaskScript.sql");
            await _context.Database.ExecuteSqlRawAsync(employeesSQLScript);
        }
    }
}