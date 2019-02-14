using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace WebUICore.Controllers
{
    public class LoginController : Controller
    {
        public IMemoryCache _cache;
        public IActionResult Index()
        {
            return View();
        }
        public LoginController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }
        public IActionResult ValidateCode()
        {
            string code = "";
            CommonHelper c = new CommonHelper();
            System.IO.MemoryStream ms = c.Create(out code, 4);
            string iCode = code.ToLower();
            _cache.Set("validata", iCode);
            return File(ms.ToArray(), @"image/png");
        }

        public IActionResult UserLogin(string userName, string pwd, string validata)
        {
            string lvalidata = validata.ToLower();
            if (lvalidata != _cache.Get("validata").ToString())
            {
                if (_cache.Get("validata") != null) {
                    _cache.Remove("validata");
                }
                return Content("验证码错误！");
            }     
            if (userName != "wang" || pwd != "1")
            {
                if (_cache.Get("validata") != null)
                {
                    _cache.Remove("validata");
                }
                return Content("用户名或者密码不正确");
            }
            if (_cache.Get("validata") != null)
            {
                _cache.Remove("validata");
            }
            return Content("ok");
        }
    }
}