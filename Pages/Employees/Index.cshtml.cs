using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectRazor.Repository;
using ProjectRazor.Models;

namespace ProjectRazor.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Employee> EmployeeList { get; private set; } = new List<Employee>();

        private readonly IEmployeeRepository _employeeRepository;

        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void OnGet()
        {
            EmployeeList = _employeeRepository.GetAll();
        }
    }
}
