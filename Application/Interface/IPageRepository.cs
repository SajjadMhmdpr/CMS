using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.News;
using Persistence;


namespace Application
{ 
    public class IPageRepository : MyGenericRepository<Page>
    {
        public IPageRepository(DB db) : base(db)
        {

        }
    }
}
