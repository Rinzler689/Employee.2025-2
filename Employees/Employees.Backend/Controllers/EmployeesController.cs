using Employees.Backend.Data;
using Employees.Backend.UnitsOfWork.Interfaces;
using Employees.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : GenericController<Employee>
{
    private readonly IGenericUnitOfWork<Employee> _employeeUnitOfWork;

    public EmployeesController(IGenericUnitOfWork<Employee> unitOfWork) : base(unitOfWork)
    {
        _employeeUnitOfWork = unitOfWork;
    }

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Employee>>> GetByNameOrLastName([FromQuery] string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return BadRequest("El parámetro de búsqueda no puede estar vacío.");
        }

        var employeesResponse = await _employeeUnitOfWork.GetAsync(
            e => e.FirstName.Contains(text) || e.LastName.Contains(text)
        );

        if (!employeesResponse.WasSuccess || !(employeesResponse.Result?.Any() ?? false))
        {
            return NotFound("No se encontraron empleados con ese criterio de búsqueda.");
        }

        return Ok(employeesResponse.Result);
    }
}