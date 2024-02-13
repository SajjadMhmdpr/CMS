using Application;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.ViewComponents
{
    public class MostViewViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            UnitOfWork db = new UnitOfWork();
            var pageGroups = db.Page.getAll("", s => s.PageTitle != null, s => s.OrderByDescending(q => q.Visit)).Take(5);

            var q = pageGroups.Select(s => new PageViewModel
            {
                id = s.PageId,
                PageTitle = s.PageTitle,
                CreateDate = s.CreateDate,
                Image =s.Image
            });

            return View(q);

        }
    }
}
