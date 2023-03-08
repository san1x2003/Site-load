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
    public class klientController : Controller
    {
        [HttpPut]
        public Klient Create(Klient Klient)
        {
            Storage.KlientStorage.Create(Klient);
            return Storage.OrderStorage.Read(Klient.Id_klient);
        }

        [HttpGet]
        public Order Read(int id_order)
        {
            return Storage.OrderStorage.Read(id_order);
        }

        [HttpPatch]
        public Order Update(int id_order, Order newOrder)
        {
            return Storage.OrderStorage.Update(id_order, newOrder);
        }

        [HttpDelete]
        public bool Delete(int id_order)
        {
            return Storage.EmployeeStorage.Delete(id_order);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}