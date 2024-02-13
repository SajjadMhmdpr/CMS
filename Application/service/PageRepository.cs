using Domain.News;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class PageRepository: IPageRepository
    {
        private DB _context;

        public PageRepository(DB db):base(db)
        {
            _context = db;
        }

        public IEnumerable<Page> GetTop(int n=5)
        {
            //return _context.Pages.ToList().Take(n).Reverse();
            return _context.Pages.ToList().TakeLast(n);

        }

        public void AddVisit(int id)
        {
             _context.Pages.Find(id).Visit++;
            _context.SaveChanges();

        }

        public Page getByID(int id)
        {
            return _context.Pages.Include("Comments").Where(s => s.PageId == id).Single();
        }

        public IEnumerable<Page> Search(string s)
        {
            var pages = _context.Pages.Where(p => p.PageTitle.Contains(s) || p.Text.Contains(s)
            || p.ShortDescription.Contains(s) || p.Tags.Contains(s) || p.PageGroup.GroupTitle.Contains(s)).Distinct();
            return pages;
        }
    }
}
