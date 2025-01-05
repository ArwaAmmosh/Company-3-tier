using Maktaba.DAL.Entity;

namespace Maktaba.DAL.DataBase
{
    public static class DBContext
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
        public static List<Department> Departments { get; set; }


    }
}
