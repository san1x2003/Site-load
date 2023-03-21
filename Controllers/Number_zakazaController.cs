using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using LABA333.Repository;
using LABA333.Models;

namespace LABA333.Controllers
{
    public class Number_zakazaController : Controller
    {
        [HttpPut]
        public Number_zakaza Create(Number_zakaza number_zakaza)
        {
            Storage.Number_zakazaStorage.Create(number_zakaza);
            return Storage.Number_zakazaStorage.Read(number_zakaza.number_zakaz);
        }

        [HttpGet]
        public Number_zakaza Read(int number_zakazId)
        {
            return Storage.Number_zakazaStorage.Read(number_zakazId);
        }

        [HttpPatch]
        public Number_zakaza Update(int number_zakazId, Number_zakaza newNumber_zakaza)
        {
            return Storage.Number_zakazaStorage.Update(number_zakazId, newNumber_zakaza);
        }

        [HttpDelete]
        public bool Delete(int number_zakazId)
        {
            return Storage.Number_zakazaStorage.Delete(number_zakazId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}