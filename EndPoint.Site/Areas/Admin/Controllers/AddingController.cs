using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.News;
using Application;
using EndPoint.Site.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using EndPoint.Site.Extention;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin2")]
    public class AddingController : Controller
    {
        private UnitOfWork _context;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public AddingController(IWebHostEnvironment hostEnvironment)
        {
            _context = new UnitOfWork();
            _webHostEnvironment = hostEnvironment;

        }

        public IActionResult CreatePageGroup()
        {
            ViewBag.groups = _context.PageGroup.getAll();

            return View();
        }
        [HttpPost]
        public IActionResult CreatePageGroup(string GroupTitle)
        {
            PageGroup pg = new PageGroup { GroupTitle = GroupTitle };
            _context.PageGroup.insert(pg);
            _context.PageGroup.save();

            ViewBag.groups = _context.PageGroup.getAll();


            return View();
        }

        public IActionResult CreatePage()
        {
            ViewBag.groups = _context.PageGroup.getAll();
            var p = new PageModelView();
            return View(p);
        }
        [HttpPost]
        public IActionResult CreatePage(PageModelView page)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            Page p = new Page
            {
                PageGroupId = _context.PageGroup.findByName(page.PageGroup),
                PageTitle = page.PageTitle,
                Text = page.Text,
                Visit = 0,
                ShortDescription = page.ShortDescription,
                Tags = page.Tags,
                //CreateDate = dateTime.AddSeconds(page.CreateDate).ToLocalTime(),
                Image = page.Image.SaveImage(_webHostEnvironment.WebRootPath, "\\News\\")
            };

            ;

            _context.Page.insert(p);
            _context.Page.save();

            ViewBag.groups = _context.PageGroup.getAll();

            return View();
        }
        [HttpGet]
        public IActionResult ShowPages()
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
        public IActionResult EditePage(int id)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = DateTime.Now - origin;

            ViewBag.groups = _context.PageGroup.getAll();
            var p = _context.Page.getByID(id);
            var page = new PageModelView
            {
                id = p.PageId,
                PageTitle = p.PageTitle,
                PageGroup = p.PageGroup.GroupTitle,
                Text = p.Text,
                Tags = p.Tags,
                Image2 = p.Image,
                ShortDescription = p.ShortDescription,
                //CreateDate2 = p.CreateDate,
                //CreateDate = Math.Floor(diff.TotalSeconds)
            };
            return View("EditePage", page);


            //return PartialView("~/Areas/Admin/Views/Adding/Components/EditePage/Default.cshtml");
        }
        [HttpPost]
        public IActionResult EditePage(PageModelView p)
        {
            string img;
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);


            if (p.Image == null)
            {
                img = p.Image2;
            }
            else
            {
                img = p.Image.SaveImage(_webHostEnvironment.WebRootPath, "\\News\\");
            }

            var page = _context.Page.getByID(p.id);

            //var page = new Page
            //{
            //    PageGroupId = _context.PageGroup.findByName(p.PageGroup),
            //    PageId = p.id,
            //    ShortDescription = p.ShortDescription,
            //    Text = p.Text,
            //    Image = img,
            //    PageTitle = p.PageTitle,
            //    Tags = p.Tags
            //};

            page.PageGroupId = _context.PageGroup.findByName(p.PageGroup);
            page.ShortDescription = p.ShortDescription;
            page.Text = p.Text;
            page.Image = img;
            page.PageTitle = p.PageTitle;
            page.Tags = p.Tags;
            //page.CreateDate = dateTime.AddSeconds(p.CreateDate).ToLocalTime();

            _context.Page.update(page);
            _context.Page.save();

            return RedirectToAction("ShowPages");
        }
    }
}
