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
    public class SkladController : Controller
    {
        [HttpPut]
        public Sklad Create(Sklad sklad)
        {
            Storage.SkladStorage.Create(sklad);
            return Storage.SkladStorage.Read(sklad.Id_sklad);
        }

        [HttpGet]
        public Sklad Read(int skladId)
        {
            return Storage.SkladStorage.Read(skladId);
        }

        [HttpPatch]
        public Sklad Update(int skladId, Sklad newsklad)
        {
            return Storage.SkladStorage.Update(skladId, newsklad);
        }

        [HttpDelete]
        public bool Delete(int skladId)
        {
            return Storage.SkladStorage.Delete(skladId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}