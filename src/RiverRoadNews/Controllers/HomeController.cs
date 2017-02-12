using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RiverRoadNews.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Date = DateTime.Now;
            return View(ViewBag.Date);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
    }
}
