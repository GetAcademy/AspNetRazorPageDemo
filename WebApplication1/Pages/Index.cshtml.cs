using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public enum FormStep
{
    Name,
    Email,
    Age,
    Registered
}

public class IndexModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public int? Age { get; set; }

    [BindProperty]
    public FormStep CurrentStep { get; set; } = FormStep.Name;

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (CurrentStep == FormStep.Name)
        {
            CurrentStep = FormStep.Email;
        }
        else if (CurrentStep == FormStep.Email)
        {
            CurrentStep = FormStep.Age;
        }
        else if (CurrentStep == FormStep.Age)
        {
            CurrentStep = FormStep.Registered;
        }

        return Page();
    }
}