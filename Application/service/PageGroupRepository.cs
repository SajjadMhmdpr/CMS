using System;
using System.Linq;
using Persistence;


namespace Application
{
    public class PageGroupeRepository : IPageGroupRepository
    {
        private DB _context;
        public PageGroupeRepository(DB db) : base(db)
        {
            _context = db;
        }

        public int findByName(string title)
        {
            return _context.PageGroups.Where(s => s.GroupTitle == title).Select(s => s.PageGroupId).Single();
        }
    }
}
