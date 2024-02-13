using System;
using Persistence;

namespace Application
{
    public class CommentRepository : ICommentRepository
    {
        public CommentRepository(DB db):base(db)
        {

        }


    }
}
