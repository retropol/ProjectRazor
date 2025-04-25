using ProjectRazor.Models;

namespace ProjectRazor.Repository
{
    public class MSSQLRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public MSSQLRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
           return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employee)
        {
         var employee1 = _context.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (employee1 != null)
            {
                employee1.Name = employee.Name;
                employee1.Email = employee.Email;
                employee1.PhotoPath = employee.PhotoPath;
                employee1.Department = employee.Department;
                _context.SaveChanges();
            }
            return employee;
        }
    }
}
