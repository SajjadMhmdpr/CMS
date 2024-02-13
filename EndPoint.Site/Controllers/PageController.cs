using Application;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class PageController : Controller
    {
        private UnitOfWork _context;
        public PageController()
        {
            _context = new UnitOfWork();
        }
        public IActionResult GetPage(int id)
        {
            _context.Page.AddVisit(id);
            var p = _context.Page.getByID(id);

            return View(p);
        }
        [HttpGet]
        public IActionResult Search(string s)
        {
            var pages = _context.Page.Search(s).Select(s => new PageViewModel
            {
                id = s.PageId,
                PageTitle = s.PageTitle,
                ShortDescription = s.ShortDescription,
                Image = s.Image,
                CreateDate = s.CreateDate
            }); ;

            return View(pages);
        }
    }
}
