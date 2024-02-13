using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.ViewComponents
{
    public class LastNewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            UnitOfWork db = new UnitOfWork();
            var pageGroups = db.Page.getAll("", s => s.PageTitle != null, s => s.OrderByDescending(q => q.CreateDate)).Take(5);

            var q = pageGroups.Select(s => new PageViewModel
            {
                id = s.PageId,
                PageTitle = s.PageTitle,
                ShortDescription = s.ShortDescription,
                Image = s.Image,
                CreateDate  =s.CreateDate
            });

            return View(q);

        }
    }
}
