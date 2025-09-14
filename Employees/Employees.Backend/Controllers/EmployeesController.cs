using Employees.Backend.Data;
using Employees.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly DataContext _context;

    public EmployeesController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Employee employee)
    {
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return Ok(employee);
    }
}