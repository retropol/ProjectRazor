using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRazor.Models;
using ProjectRazor.Repository;

namespace ProjectRazor.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; } = default!;

        public void OnGet(int id)
        {
            Employee = _employeeRepository.GetById(id);
        }

        //public IActionResult OnPost(Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _employeeRepository.Update(employee);
        //        return RedirectToPage("Index");
        //    }
        //    return Page();
        //}

        public IActionResult OnPost(Employee e)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(Employee);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
