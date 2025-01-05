using Maktaba.BLL.Abstraction;
using Maktaba.DAL.Entity;
using Maktaba.DAL.DataBase;
namespace Maktaba.BLL.Implemention
{
    internal class EmployeeRepo : IEmployeeRepo
    {
      public bool CreateEmployee(Employee employee)
        {
            try
            {
                if (employee == null || employee.Id <= 0 ) 
                { 
                    return false;
                }
                DBContext.Employees.Add(employee);
                return true;

            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public bool DeleteEmployee(Employee employee)
        {
            try
            {
                if (employee.Id <= 0) 
                    return false;
                bool IsFound = false;
                foreach (var emp in DBContext.Employees)
                {
                    if (emp.Id == employee.Id)
                    {
                        emp.ToggleStatus();
                        IsFound = true;
                    }
                }
                return IsFound;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Employee GetEmployee(int id)
        {
           Employee employee= DBContext.Employees.Where(a=>a.Id == id).FirstOrDefault();
           return employee;
        }

        public List<Employee> GetEmployees()
        {
            return DBContext.Employees;
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                if (employee is null|| employee.Id <= 0)
                    return false;
                bool IsFound=false;
                if (employee.Name != "" && employee.Salary != 0)
                {
                    foreach (Employee emp in DBContext.Employees)
                    {
                        if (emp.Id == employee.Id)
                        {
                            emp.Update(employee.Name, employee.Salary);
                            IsFound = true;
                        }
                    }

                }
                return IsFound;
            }
            catch (Exception ex)
            {
                return false;
            }
       }
    }
}
