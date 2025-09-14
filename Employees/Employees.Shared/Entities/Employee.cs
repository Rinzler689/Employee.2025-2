using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Shared.Entities;

public class Employee
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Apellido")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string LastName { get; set; } = null!;

    public bool? IsActive { get; set; }

    [Display(Name = "Fecha de Contratación")]
    [DataType(DataType.Date)]
    public DateTime? HireDate { get; set; }

    [Display(Name = "Salario")]
    [Range(1000000, double.MaxValue, ErrorMessage = "El campo {0} debe ser mínimo de $1,000,000.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public decimal Salary { get; set; }
}