using Employees.Shared.Entities;

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
        await CheckEmployeesAsync();
    }

    private async Task CheckEmployeesAsync()
    {
        if (!_context.Employees.Any())
        {
            _context.Employees.Add(new Employee { LastName = "Perez", IsActive = true, HireDate = new DateTime(2020, 5, 10), Salary = 1500000, FirstName = "Pepito" });
            _context.Employees.Add(new Employee { LastName = "Gomez", IsActive = true, HireDate = new DateTime(2019, 3, 15), Salary = 2000000, FirstName = "Maria" });
            _context.Employees.Add(new Employee { LastName = "Lopez", IsActive = false, HireDate = new DateTime(2021, 7, 20), Salary = 1800000, FirstName = "Carlos" });
            _context.Employees.Add(new Employee { LastName = "Martinez", IsActive = true, HireDate = new DateTime(2018, 1, 5), Salary = 2500000, FirstName = "Luisa" });
            _context.Employees.Add(new Employee { LastName = "Ramirez", IsActive = true, HireDate = new DateTime(2022, 11, 30), Salary = 1700000, FirstName = "Andres" });
            _context.Employees.Add(new Employee { LastName = "Castro", IsActive = false, HireDate = new DateTime(2017, 6, 25), Salary = 2200000, FirstName = "Laura" });
            _context.Employees.Add(new Employee { LastName = "Sanchez", IsActive = true, HireDate = new DateTime(2023, 4, 12), Salary = 1950000, FirstName = "Jorge" });
            _context.Employees.Add(new Employee { LastName = "Torres", IsActive = true, HireDate = new DateTime(2016, 9, 1), Salary = 2100000, FirstName = "Diana" });
            _context.Employees.Add(new Employee { LastName = "Hernandez", IsActive = true, HireDate = new DateTime(2021, 2, 8), Salary = 2300000, FirstName = "Felipe" });
            _context.Employees.Add(new Employee { LastName = "Vargas", IsActive = false, HireDate = new DateTime(2015, 12, 18), Salary = 2400000, FirstName = "Carolina" });
            await _context.SaveChangesAsync();
        }
    }
}