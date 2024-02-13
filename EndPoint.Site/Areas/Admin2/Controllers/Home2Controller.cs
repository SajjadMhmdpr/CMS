using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.Site.Areas.Admin.Models;
using Application;
using Microsoft.AspNetCore.Hosting;
using Domain.News;
using EndPoint.Site.Extention;

namespace EndPoint.Site.Areas.Admin2.Controllers
{
    [Area("Admin2")]
    public class Home2Controller : Controller
    {
        private UnitOfWork _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public Home2Controller(IWebHostEnvironment hostEnvironment)
        {
            _context = new UnitOfWork();
            _webHostEnvironment = hostEnvironment;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var pages = _context.Page.getAll("PageGroup").Select(s => new PageModelView
            {
                id = s.PageId,
                Image2 = s.Image,
                PageTitle = s.PageTitle,
                ShortDescription = s.ShortDescription,
                PageGroup = s.PageGroup.GroupTitle
            });
            ViewBag.groups = _context.PageGroup.getAll();
            return View(pages);
        }


        [HttpGet]
        public IActionResult LoadCreatePageModal()
        {
            ViewBag.groups = _context.PageGroup.getAll();
            var p = new PageModelView();
            p.id = -1;
            return PartialView("_CreatePageModalPartialView", p);
        }

        [HttpPost]
        public IActionResult SubmitCreatePageModal(PageModelView page)
        {
            if (ModelState.IsValid)
            {
                Page p = new Page
                {
                    PageGroupId = _context.PageGroup.findByName(page.PageGroup),
                    PageTitle = page.PageTitle,
                    Text = page.Text,
                    Visit = 0,
                    ShortDescription = page.ShortDescription,
                    Tags = page.Tags,
                    CreateDate = page.CreateDate.toMiladi(),
                    Image = page.Image.SaveImage(_webHostEnvironment.WebRootPath, "\\News\\")
                };



                _context.Page.insert(p);
                _context.Page.save();

                return new JsonResult(new { status = "Success" });
            }


            return new JsonResult(new { status = "Error" });
        }

        [HttpGet]
        public IActionResult LoadEditePageModal(int PageId)
        {
            ViewBag.groups = _context.PageGroup.getAll();
            var p = _context.Page.getByID(PageId);
            var page = new PageModelView
            {
                id = p.PageId,
                PageTitle = p.PageTitle,
                ShortDescription = p.ShortDescription,
                Text = p.Text,
                Tags = p.Tags,
                PageGroup = _context.PageGroup.getByID(p.PageGroupId).GroupTitle,
                CreateDate=p.CreateDate.toShamsi(),
                Image2 = p.Image
            };
            return PartialView("_EditePageModalPartialView", page);
        }
        [HttpPost]
        public IActionResult SubmitEditePageModal(PageModelView page)
        {
            if (ModelState.IsValid)
            {
                var p = _context.Page.getByID(page.id);

                p.PageGroupId = _context.PageGroup.findByName(page.PageGroup);
                p.PageTitle = page.PageTitle;
                p.Text = page.Text;
                p.ShortDescription = page.ShortDescription;
                p.Tags = page.Tags;
                p.CreateDate = page.CreateDate.toMiladi();
                if(page.Image!=null)
                     p.Image = page.Image.SaveImage(_webHostEnvironment.WebRootPath, "\\News\\");

                _context.Page.update(p);
                _context.Page.save();

                return new JsonResult(new { status = "Success" });
            }


            return new JsonResult(new { status = "Error" });
        }

        [HttpPost]
        public IActionResult DeletePage(int PageId)
        {
            if (ModelState.IsValid)
            {

                _context.Page.delete(PageId);
                _context.Page.save();

                return new JsonResult(new { status = "Success" });
            }


            return new JsonResult(new { status = "Error" });
        }



    }
}
