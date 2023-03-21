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
    public class TovarController : Controller
    {
        [HttpPut]
        public Tovar Create(Tovar tovar)
        {
            Storage.TovarStorage.Create(tovar);
            return Storage.TovarStorage.Read(tovar.Id_product);
        }

        [HttpGet]
        public Tovar Read(int tovarId)
        {
            return Storage.TovarStorage.Read(tovarId);
        }

        [HttpPatch]
        public Tovar Update(int tovarId, Tovar newtovar)
        {
            return Storage.TovarStorage.Update(tovarId, newtovar);
        }

        [HttpDelete]
        public bool Delete(int tovarId)
        {
            return Storage.TovarStorage.Delete(tovarId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}