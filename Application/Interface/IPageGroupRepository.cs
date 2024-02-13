using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.News;
using Persistence;


namespace Application
{
    public class IPageGroupRepository : MyGenericRepository<PageGroup>
    {
        public IPageGroupRepository(DB db) : base(db)
        {

        }
    }
}
