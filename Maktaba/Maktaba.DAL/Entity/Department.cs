﻿namespace Maktaba.DAL.Entity
{
    public class Department
    {
        public Department(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public List<Employee> Employees { get; private set; } = new List<Employee>();
    }
}
