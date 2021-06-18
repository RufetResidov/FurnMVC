using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furndaqaaqas.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult MyAccount()
        {
            return View();
        }
    }
}
