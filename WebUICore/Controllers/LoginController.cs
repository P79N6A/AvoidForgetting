using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUICore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidateCode() {
            string code = "";
            CommonHelper c = new CommonHelper();
            System.IO.MemoryStream ms = c.Create(out code);
            //HttpContext.Session.SetString("LoginValidateCode",code);
            Response.Body.Dispose();
            return File(ms.ToArray(), @"image/png");
        }
    }
}