namespace Maktaba.DAL.Entity
{
    public class Employee
    {
        public Employee(long id, string name, decimal salary, DateTime createdon, bool isDeleted)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Createdon = createdon;
            IsDeleted = isDeleted;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime Createdon { get; private set; }= DateTime.Now;
        public bool IsDeleted { get; private set; }= false;
        public void ToggleStatus()
        { 
            IsDeleted = !IsDeleted;
        }
        public void Update(string name , decimal salary)
        {
           Name = name;
           Salary = salary;
        }
        
    }
}
