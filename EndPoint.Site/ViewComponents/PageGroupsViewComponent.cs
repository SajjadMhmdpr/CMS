using Application;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.ViewComponents
{
    public class PageGroupsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(bool forMeno=false)
        {

            UnitOfWork db = new UnitOfWork();
            var pageGroups = db.PageGroup.getAll("Pages", s => s.GroupTitle != null, s => s.OrderBy(q => q.GroupTitle));

            if (forMeno)
            {
                var q = pageGroups.Select(s => new PageGroupsViewModel
                {
                    Number = -5,
                    GroupTitle = s.GroupTitle,
                });

                return View(q);
            }
            else
            {
                var q = pageGroups.Select(s => new PageGroupsViewModel
                {
                    Number = s.Pages.Count,
                    GroupTitle = s.GroupTitle,
                });

                return View(q);
            }

        

        }
    }
}
