using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.News;
using Persistence;

namespace Application
{
    public class UnitOfWork : IDisposable
    {
        private DB _context = new DB();

        private PageRepository _Page;
        private PageGroupeRepository _PageGroup;
        private CommentRepository _Comment;


        public PageRepository Page
        {
            get
            {
                if (_Page == null)
                    _Page = new PageRepository(_context);

                return _Page;
            } 
        }
        public PageGroupeRepository PageGroup
        {
            get
            {
                if (_PageGroup == null)
                    _PageGroup = new PageGroupeRepository(_context);

                return _PageGroup;
            }
        }
        public CommentRepository Comment
        {
            get
            {
                if (_Comment== null)
                    _Comment = new CommentRepository(_context);


                return _Comment;
            }
        }





        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
