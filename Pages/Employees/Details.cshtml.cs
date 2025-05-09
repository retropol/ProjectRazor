using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRazor.Models;
using ProjectRazor.Repository;

namespace ProjectRazor.Pages.Employees
{
    public class DetailsModel : PageModel
    {

        private readonly IEmployeeRepository _employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Employee { get; set; } = default!;
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetById(id);

            if (Employee==null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
