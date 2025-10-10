using Employees.Shared.Entities;
using Employees.Shared.Responses;

namespace Employees.Backend.Repositories.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<ActionResponse<IEnumerable<Employee>>> GetByNameLastNameAsync(string search);
    }
}