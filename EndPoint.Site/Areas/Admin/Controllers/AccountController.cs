using EndPoint.Site.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    public class Account2Controller : Controller
    {
        private UserManager<IdentityUser> _UserManager;
        private SignInManager<IdentityUser> _SignInManager;

        public Account2Controller(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;

        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel user)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            return View();
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogOut(int a)
        {
            return View();
        }
    }
}
