using ProjectRazor.Models;

namespace ProjectRazor.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(int id);

        Employee Update(Employee employee);
    }
}
