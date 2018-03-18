using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shops.Models;

namespace Shops.Controllers
{
    public class HomeController : Controller
    {
        string db = "storage.json";

        [ResponseCache(Duration = 50)]
        public IActionResult Index()
        {
            var boots = Storage.GetBoots(db);

            return View(boots.Values.ToList());
        }
    }
}
