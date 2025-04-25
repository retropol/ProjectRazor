using ProjectRazor.Models;

namespace ProjectRazor.Repository
{
    public class MockData : IEmployeeRepository
    {
        private readonly List<Employee> _employees;

        public MockData()
        {
            _employees = new List<Employee>()
                {
                    new Employee() { Id = 1, Name = "Ahmet Yılmaz", Email = "ahmet.yilmaz@gmail.com", PhotoPath = "1.jpg", Department = "Muhasebe" },
                    new Employee() { Id = 2, Name = "Hasan Cengiz", Email = "hasan.cengiz@gmail.com", PhotoPath = "2.jpg", Department = "Muhasebe" },
                    new Employee() { Id = 3, Name = "Canan Turan", Email = "canan.turan@gmail.com", PhotoPath = "3.jpg", Department = "Muhasebe" },
                    new Employee() { Id = 4, Name = "Volkan Yükselen", Email = "volkan.yukselen@gmail.com", PhotoPath = "4.jpg", Department = "Muhasebe" }
                };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
           return _employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employee)
        {
          Employee employee1 = _employees.FirstOrDefault(e => e.Id == employee.Id);

            if (employee1 != null)
            {
                employee1.Name = employee.Name;
                employee1.Email = employee.Email;
                employee1.PhotoPath = employee.PhotoPath;
                employee1.Department = employee.Department;
            }
            return employee;
        }
    }
}
