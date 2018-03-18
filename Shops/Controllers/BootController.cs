using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shops.Models;

namespace Shops.Controllers
{
    public class BootController : Controller
    {
        string db = "storage.json";

        public IActionResult Index(int id)
        {
            Boot boot = Storage.GetBootById(db, id);
            ViewBag.BootId = id;
            return View(boot);
        }
    }
}
