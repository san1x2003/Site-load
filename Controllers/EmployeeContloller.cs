using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using LABA333.Models;
using LABA333.Repository;


namespace LABA333.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPut]
        public Employee Create(Employee employee)
        {
            Storage.EmployeeStorage.Create(employee);
            return Storage.EmployeeStorage.Read(employee.Id);
        }

        [HttpGet]
        public Employee Read(int employeeId)
        {
            return Storage.EmployeeStorage.Read(employeeId);
        }

        [HttpPatch]
        public Employee Update(int employeeId, Employee newEmployee)
        {
            return Storage.EmployeeStorage.Update(employeeId, newEmployee);
        }

        [HttpDelete]
        public bool Delete(int employeeId)
        {
            return Storage.EmployeeStorage.Delete(employeeId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}