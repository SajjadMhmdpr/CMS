using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using EndPoint.Site.Areas.Admin.Models;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Admin.ViewComponents
{
    public class EditePageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            UnitOfWork db = new UnitOfWork();

            var p = new PageModelView();

            return View(p);

        }
    }
}
