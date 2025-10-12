using Employees.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Employees.Frontend.Components.Pages.Workers;

public partial class WorkerForm
{
    private EditContext editContext = null!;

    [EditorRequired, Parameter] public Employee Employee { get; set; } = null!;
    [EditorRequired, Parameter] public EventCallback OnValidSubmit { get; set; }
    [EditorRequired, Parameter] public EventCallback ReturnAction { get; set; }

    protected override void OnInitialized()
    {
        editContext = new(Employee);
    }
}