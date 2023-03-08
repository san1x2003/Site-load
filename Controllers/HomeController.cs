using System.Linq;
using LABA333.Models;
using Microsoft.AspNetCore.Mvc;
using LABA333.Models;

namespace LABA333.Controllers
{
    public class HomeController : Controller
    {
        ShopContext db;
        public HomeController(ShopContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Employees.ToList());
        }
    }
}
