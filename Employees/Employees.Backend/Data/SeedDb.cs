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
            _context.Employees.Add(new Employee { LastName = "Morales", IsActive = true, HireDate = new DateTime(2019, 8, 14), Salary = 1600000, FirstName = "Julian" });
            _context.Employees.Add(new Employee { LastName = "Cardenas", IsActive = false, HireDate = new DateTime(2020, 3, 22), Salary = 1850000, FirstName = "Angela" });
            _context.Employees.Add(new Employee { LastName = "Gonzalez", IsActive = true, HireDate = new DateTime(2018, 11, 10), Salary = 2100000, FirstName = "Ricardo" });
            _context.Employees.Add(new Employee { LastName = "Rojas", IsActive = true, HireDate = new DateTime(2021, 5, 5), Salary = 1750000, FirstName = "Natalia" });
            _context.Employees.Add(new Employee { LastName = "Diaz", IsActive = false, HireDate = new DateTime(2017, 4, 9), Salary = 2200000, FirstName = "Sebastian" });
            _context.Employees.Add(new Employee { LastName = "Mendoza", IsActive = true, HireDate = new DateTime(2016, 7, 2), Salary = 2600000, FirstName = "Camila" });
            _context.Employees.Add(new Employee { LastName = "Navarro", IsActive = false, HireDate = new DateTime(2019, 10, 19), Salary = 1900000, FirstName = "Esteban" });
            _context.Employees.Add(new Employee { LastName = "Jimenez", IsActive = true, HireDate = new DateTime(2023, 1, 28), Salary = 1800000, FirstName = "Sara" });
            _context.Employees.Add(new Employee { LastName = "Acosta", IsActive = true, HireDate = new DateTime(2018, 6, 30), Salary = 2000000, FirstName = "Leonardo" });
            _context.Employees.Add(new Employee { LastName = "Reyes", IsActive = false, HireDate = new DateTime(2015, 9, 12), Salary = 2400000, FirstName = "Tatiana" });
            _context.Employees.Add(new Employee { LastName = "Guerrero", IsActive = true, HireDate = new DateTime(2017, 3, 16), Salary = 1700000, FirstName = "David" });
            _context.Employees.Add(new Employee { LastName = "Camacho", IsActive = true, HireDate = new DateTime(2020, 2, 11), Salary = 1900000, FirstName = "Isabela" });
            _context.Employees.Add(new Employee { LastName = "Suarez", IsActive = false, HireDate = new DateTime(2022, 7, 25), Salary = 2100000, FirstName = "Mateo" });
            _context.Employees.Add(new Employee { LastName = "Ortega", IsActive = true, HireDate = new DateTime(2021, 9, 3), Salary = 1750000, FirstName = "Valentina" });
            _context.Employees.Add(new Employee { LastName = "Peña", IsActive = false, HireDate = new DateTime(2016, 5, 17), Salary = 2300000, FirstName = "Jhon" });
            _context.Employees.Add(new Employee { LastName = "Lara", IsActive = true, HireDate = new DateTime(2018, 12, 5), Salary = 1800000, FirstName = "Laura" });
            _context.Employees.Add(new Employee { LastName = "Cortes", IsActive = true, HireDate = new DateTime(2019, 11, 22), Salary = 2500000, FirstName = "Andres" });
            _context.Employees.Add(new Employee { LastName = "Nieto", IsActive = false, HireDate = new DateTime(2017, 1, 8), Salary = 2200000, FirstName = "Juliana" });
            _context.Employees.Add(new Employee { LastName = "Pineda", IsActive = true, HireDate = new DateTime(2020, 8, 13), Salary = 1900000, FirstName = "Carlos" });
            _context.Employees.Add(new Employee { LastName = "Velasquez", IsActive = true, HireDate = new DateTime(2015, 10, 2), Salary = 2100000, FirstName = "Natalia" });
            _context.Employees.Add(new Employee { LastName = "Salazar", IsActive = false, HireDate = new DateTime(2016, 2, 19), Salary = 1600000, FirstName = "Daniel" });
            _context.Employees.Add(new Employee { LastName = "Avila", IsActive = true, HireDate = new DateTime(2022, 3, 7), Salary = 1750000, FirstName = "Paula" });
            _context.Employees.Add(new Employee { LastName = "Rincon", IsActive = true, HireDate = new DateTime(2018, 5, 14), Salary = 2000000, FirstName = "Javier" });
            _context.Employees.Add(new Employee { LastName = "Escobar", IsActive = false, HireDate = new DateTime(2019, 9, 26), Salary = 1850000, FirstName = "Daniela" });
            _context.Employees.Add(new Employee { LastName = "Montoya", IsActive = true, HireDate = new DateTime(2023, 4, 1), Salary = 1950000, FirstName = "Felipe" });
            _context.Employees.Add(new Employee { LastName = "Gutierrez", IsActive = true, HireDate = new DateTime(2020, 6, 23), Salary = 2300000, FirstName = "Ana" });
            _context.Employees.Add(new Employee { LastName = "Blanco", IsActive = false, HireDate = new DateTime(2017, 8, 29), Salary = 1750000, FirstName = "Mauricio" });
            _context.Employees.Add(new Employee { LastName = "Aguilar", IsActive = true, HireDate = new DateTime(2016, 10, 18), Salary = 2400000, FirstName = "Tatiana" });
            _context.Employees.Add(new Employee { LastName = "Osorio", IsActive = true, HireDate = new DateTime(2021, 1, 21), Salary = 2100000, FirstName = "Cristian" });
            _context.Employees.Add(new Employee { LastName = "Fuentes", IsActive = false, HireDate = new DateTime(2019, 12, 9), Salary = 1850000, FirstName = "Sofia" });
            _context.Employees.Add(new Employee { LastName = "Prieto", IsActive = true, HireDate = new DateTime(2022, 9, 27), Salary = 1950000, FirstName = "Miguel" });
            _context.Employees.Add(new Employee { LastName = "Garcia", IsActive = true, HireDate = new DateTime(2018, 11, 6), Salary = 2200000, FirstName = "Carolina" });
            _context.Employees.Add(new Employee { LastName = "Rivera", IsActive = false, HireDate = new DateTime(2015, 4, 11), Salary = 2500000, FirstName = "Oscar" });
            _context.Employees.Add(new Employee { LastName = "Cano", IsActive = true, HireDate = new DateTime(2023, 2, 17), Salary = 1900000, FirstName = "Vanessa" });
            _context.Employees.Add(new Employee { LastName = "Martinez", IsActive = true, HireDate = new DateTime(2021, 7, 8), Salary = 2050000, FirstName = "Diego" });
            _context.Employees.Add(new Employee { LastName = "Forero", IsActive = false, HireDate = new DateTime(2016, 12, 3), Salary = 1600000, FirstName = "Gloria" });
            _context.Employees.Add(new Employee { LastName = "Ramos", IsActive = true, HireDate = new DateTime(2019, 10, 20), Salary = 2100000, FirstName = "Lucas" });
            _context.Employees.Add(new Employee { LastName = "Chavez", IsActive = true, HireDate = new DateTime(2017, 6, 12), Salary = 1800000, FirstName = "Fernanda" });
            _context.Employees.Add(new Employee { LastName = "Ruiz", IsActive = false, HireDate = new DateTime(2020, 1, 30), Salary = 2000000, FirstName = "Adrian" });
            _context.Employees.Add(new Employee { LastName = "Bonilla", IsActive = true, HireDate = new DateTime(2018, 8, 4), Salary = 2300000, FirstName = "Daniel" });
            _context.Employees.Add(new Employee { LastName = "Mejia", IsActive = true, HireDate = new DateTime(2022, 5, 16), Salary = 1950000, FirstName = "Monica" });
            await _context.SaveChangesAsync();
        }
    }
}