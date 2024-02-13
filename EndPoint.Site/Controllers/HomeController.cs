using Application;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork _context;

        public HomeController()
        {
            _context = new UnitOfWork();
        }

        public IActionResult Index()
        {
            ViewBag.groups = _context.PageGroup.getAll();


            var pages = _context.Page.GetTop();

            ViewBag.pages = pages.Select(s => new PageViewModel
            {
                id = s.PageId,
                PageTitle = s.PageTitle,
                ShortDescription = s.ShortDescription,
                Image = s.Image,
                CreateDate = s.CreateDate
            });
            return View();


        }
        public IActionResult Indexss()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
