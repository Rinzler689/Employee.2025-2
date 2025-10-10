using Employees.Backend.Data;
using Employees.Backend.Repositories.Interfaces;
using Employees.Shared.Entities;
using Employees.Shared.Responses;
using Microsoft.EntityFrameworkCore;

namespace Employees.Backend.Repositories.Implementations
{
    public class EmployeesRepository : GenericRepository<Employee>, IEmployeesRepository
    {
        private readonly DataContext _context;

        public EmployeesRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ActionResponse<IEnumerable<Employee>>> GetByNameLastNameAsync(string search)
        {
            var employees = await _context.Employees
                .Where(e => e.FirstName.Contains(search) || e.LastName.Contains(search))
                .ToListAsync();

            if (!employees.Any())
            {
                return new ActionResponse<IEnumerable<Employee>>
                {
                    WasSuccess = false,
                    Message = "No se encontraron empleados con ese criterio"
                };
            }

            return new ActionResponse<IEnumerable<Employee>>
            {
                WasSuccess = true,
                Result = employees
            };
        }
    }
}