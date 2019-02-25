using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUICore.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult CreateNote()
        {
            return View();
        }

        public IActionResult CreateMinder()
        {
            return View();
        }
    }
}