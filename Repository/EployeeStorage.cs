using System;
using LABA333.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace LABA333.Repository
{
    public class EmployeeStorage
    {
        private Dictionary<int, Employee> Employees { get; } = new Dictionary<int, Employee>();

        public void Create(Employee Employee)
        {
            Employees.Add(Employee.Id, Employee);
        }

        public Employee Read(int Id)
        {
            return Employees[Id];
        }

        public Employee Update(int Id, Employee newEmployee)
        {
            Employees[Id] = newEmployee;
            return Employees[Id];
        }

        public bool Delete(int Id)
        {
            return Employees.Remove(Id);
        }
    }
}