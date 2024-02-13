using Domain.News;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ICommentRepository : MyGenericRepository<Comment>
    {
        public ICommentRepository(DB db):base(db)
        {

        }
    }
}
