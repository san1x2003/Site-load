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
    public class KlientController : Controller
    {
        [HttpPut]
        public Klient Create(Klient klient)
        {
            Storage.KlientStorage.Create(klient);
            return Storage.KlientStorage.Read(klient.Id_klient);
        }

        [HttpGet]
        public Klient Read(int klientId)
        {
            return Storage.KlientStorage.Read(klientId);
        }

        [HttpPatch]
        public Klient Update(int klientId, Klient newklient)
        {
            return Storage.KlientStorage.Update(klientId, newklient);
        }

        [HttpDelete]
        public bool Delete(int klientId)
        {
            return Storage.KlientStorage.Delete(klientId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}