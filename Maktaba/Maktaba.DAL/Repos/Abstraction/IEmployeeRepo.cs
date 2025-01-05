using Maktaba.DAL.Entity;
namespace Maktaba.BLL.Abstraction
{
    public interface IEmployeeRepo
    {
        public bool CreateEmployee(Employee employee);
        public bool UpdateEmployee(Employee employee);
        public bool DeleteEmployee(Employee employee);
        public Employee GetEmployee(int id);
        public List<Employee> GetEmployees();
    }
}
